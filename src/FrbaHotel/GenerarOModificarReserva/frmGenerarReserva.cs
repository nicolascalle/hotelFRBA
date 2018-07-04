using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmGenerarReserva : Form
    {
        long nroHotel;
        SqlDataReader dataReader;
        string regimen;
        string numReserva;
        string tipoUsuario;
        public frmGenerarReserva(string tipoUsuario)
        {
            InitializeComponent();
            dtFechaInicioReserva.MinDate = dtFechaInicioReserva.Value;
            if (tipoUsuario == "guest")
            {

            }
            else if (tipoUsuario == "recepcionista")
            {
                nroHotel = DBConnection.getInstance().getUsuario().getHotelUltimoLogin();
                tbNombreHotel.Text = nroHotel.ToString();
                tbNombreHotel.Enabled = false;
            }
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.camposObligatoriosCompletos())
            {
                this.determinarRegimen();
                if (this.determinarDisponibilidadDelPedido())
                {
                    int costoDeRegimen = this.calcularCostoDeHabitacion();
                    dataReader.Close(); // por el calcularCostoDeHabitacion
                    frmInformarCostoDeLaReserva ventanaCosto = new frmInformarCostoDeLaReserva(costoDeRegimen);
                    ventanaCosto.ShowDialog();
                    if (ventanaCosto.aceptoCosto())
                    {
                        frmSeleccionarSiSeAlojoAlgunaVez ventanaCliente = new frmSeleccionarSiSeAlojoAlgunaVez();
                        ventanaCliente.ShowDialog();
                        Reserva nuevaReserva = new Reserva(dtFechaInicioReserva.Value, dtFechaFinalReserva.Value, Convert.ToInt32(tbNombreHotel.Text), DBConnection.getInstance().getCliente());//falta enviar regimen // cbTipoRegimen.Text.ToString()); Convert.ToInt32(cbTipoHab.Text.ToString()), 
                        nuevaReserva.guardar();
                        this.obtenerNumeroReserva(); //solo se puede obtener el numero despues de haberlo guardado
                        nuevaReserva.setCodigo(Convert.ToInt32(this.numReserva));
                       // for (int i = 0; i < Convert.ToInt32(tbCantHabitaciones.Text); i++)
                        nuevaReserva.guardarReservaPorHabitacion();//falta que se haga varias veces

                        
                        this.Close();
                        frmMostrarNumeroDeReserva ventanaMostrarNumReserva = new frmMostrarNumeroDeReserva(this.numReserva);
                        ventanaMostrarNumReserva.ShowDialog();
                    }
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("No hay disponibilidad de habitaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Campos obligatorios incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        

        private bool camposObligatoriosCompletos()
        {
            return new List<Control> { tbCantHabitaciones, cbTipoHab }.All(form => form.Text.Length != 0);
        }

        private bool determinarDisponibilidadDelPedido()
        {
            string query = "SELECT COUNT(habi_nro) AS cantDisponibles FROM FAAE.Habitacion JOIN FAAE.Hotel ON (habi_hote_codigo = hote_codigo) JOIN FAAE.Regimen_Hotel ON (hote_codigo = reho_hote_codigo) WHERE habi_tipo_codigo = (SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "') AND habi_habilitada = 1 AND reho_regi_codigo LIKE '" + regimen + "' AND hote_codigo = " + tbNombreHotel.Text.ToString() + " AND NOT exists (SELECT NULL FROM FAAE.Reserva_Habitacion WHERE reha_hote_codigo = hote_codigo  AND habi_nro = reha_habi_nro)";
           dataReader = DBConnection.getInstance().executeQuery(query);
           if (dataReader.Read())
           {
               bool hayDisponibilidad = Convert.ToInt32(dataReader["cantDisponibles"].ToString()) >= Convert.ToInt32(tbCantHabitaciones.Text);
               dataReader.Close();
               return hayDisponibilidad;
           }
           else
               dataReader.Close();
               return false;
           
        }

        private int calcularCostoDeHabitacion()
        {
            dataReader.Close();
            string query = "SELECT regi_precio_base FROM FAAE.Regimen WHERE regi_nombre LIKE '" + regimen + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            int precioRegimen = (int) Convert.ToDecimal(dataReader["regi_precio_base"].ToString());
            dataReader.Close();

            query = "SELECT tipo_cant_personas FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            int precioTipo = Convert.ToInt32(dataReader["tipo_cant_personas"].ToString());
            dataReader.Close();

            query = "SELECT hote_recarga_estrellas FROM FAAE.Hotel WHERE hote_nombre LIKE '" + this.cambiarNumeroHotelPorNombreHotel() + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            int precioHotel = (int) (Convert.ToDecimal(dataReader["hote_recarga_estrellas"].ToString()));
            dataReader.Close();
            
            return precioRegimen * precioTipo * precioHotel;   
        }

        private void determinarRegimen()
        {
            if (cbTipoRegimen.Text.Length == 0)
            {
                frmEleccionDeRegimen ventanaEleccion = new frmEleccionDeRegimen();
                ventanaEleccion.ShowDialog();
                cbTipoRegimen.Text = ventanaEleccion.regimenElegido();
            }
            regimen = cbTipoRegimen.Text.ToString();
            
        }

        private string cambiarNombreHotelPorNumeroHotel() //cuando el usuario escriba directamente el nombre
        {
            string query = "SELECT hote_codigo FROM FAAE.Hotel WHERE hote_nombre LIKE '" + tbNombreHotel.Text.ToString() + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            string numeroHotel =  dataReader["hote_codigo"].ToString();
            dataReader.Close();
            return numeroHotel;
        }

        private string cambiarNumeroHotelPorNombreHotel() //cuando se hardcodee el numero de hotel en donde esta el recepcionista que genera la reserva
        {
            string nombreHotel;
            string query = "SELECT hote_nombre FROM FAAE.Hotel WHERE hote_codigo  = " + nroHotel.ToString();
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            nombreHotel = dataReader["hote_nombre"].ToString();
            dataReader.Close();
            return nombreHotel;
        }

        private void frmGenerarReserva_Load(object sender, EventArgs e)
        { }

        private void obtenerNumeroReserva()
        {
            InitializeComponent();
            SqlDataReader dataReader;
            string query = "SELECT @@IDENTITY ultimaReserva";
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            numReserva = dataReader["ultimaReserva"].ToString();
            dataReader.Close();
        }

    }

}
