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
        long nroHotel = DBConnection.getInstance().getUsuario().getHotelUltimoLogin();
        SqlDataReader dataReader;
        string regimen;
        public frmGenerarReserva()
        {
            InitializeComponent();
            dtFechaInicioReserva.MinDate = dtFechaInicioReserva.Value;
            tbNombreHotel.Text = nroHotel.ToString();
            tbNombreHotel.Enabled = false;
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
                        Reserva nuevaReserva = new Reserva(dtFechaInicioReserva.Value, dtFechaFinalReserva.Value, cbTipoHab.Text.ToString(), cbTipoRegimen.Text.ToString()); //Convert.ToInt32(cbTipoHab.Text.ToString()), 
                        nuevaReserva.guardar();

                    }
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("No hay disponibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           string query = "SELECT COUNT(habi_nro) AS cantDisponibles FROM FAAE.Habitacion JOIN FAAE.Hotel ON (habi_hote_codigo = hote_codigo) JOIN FAAE.Regimen_Hotel ON (hote_codigo = reho_hote_codigo) WHERE habi_tipo_codigo = (SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "') AND habi_habilitada = 1 AND reho_regi_codigo LIKE '" + regimen + "' AND hote_codigo = " + tbNombreHotel.Text.ToString();//this.cambiarNombreHotelPorNumeroHotel();
           dataReader = DBConnection.getInstance().executeQuery(query);
           dataReader.Read();
           bool hayDisponibilidad =  Convert.ToInt32(dataReader["cantDisponibles"].ToString()) >= Convert.ToInt32(tbCantHabitaciones.Text);          
           dataReader.Close();
           return hayDisponibilidad;
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
            
            return precioRegimen * precioTipo * precioHotel * Convert.ToInt32(tbCantHabitaciones.Text);   
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
    }

}
