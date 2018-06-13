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
        SqlDataReader dataReader;
        string regimenQueElegio;
        public frmGenerarReserva()
        {
            InitializeComponent();
            dtFechaInicioReserva.MinDate = dtFechaInicioReserva.Value;
        }

        private void frmGenerarReserva_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.noHayCamposSinSeleccionar())
            {
                if (cbTipoRegimen.Text.Length == 0)
                {

                    frmEleccionDeRegimen ventanaEleccion = new frmEleccionDeRegimen(this.cambiarNombreHotelPorNumeroHotel());
                    dataReader.Close();
                    ventanaEleccion.Show();
                    regimenQueElegio = ventanaEleccion.regimenElegido();
                }
                else
                {
                    regimenQueElegio = cbTipoRegimen.Text.ToString();
                }
                if (this.determinarDisponibilidadDelPedido())
                {
                    //Reserva nuevaReserva = new Reserva(dtFechaInicioReserva.Value, dtFechaFinalReserva.Value, cbTipoHab.Text.ToString(), cbTipoRegimen.Text.ToString()); //Convert.ToInt32(cbTipoHab.Text.ToString()), 
                    //nuevaReserva.guardar();
                    frmInformarCostoDeLaHabitacion ventanaCosto = new frmInformarCostoDeLaHabitacion(this.calcularCostoDeHabitacion());
                    ventanaCosto.Show();
                    dataReader.Close();
                }
                else
                {
                    MessageBox.Show("No hay un carajo");
                }

            }
            Close();
        }
        //

        private bool noHayCamposSinSeleccionar()
        {
            return cbTipoHab.Text.Length != 0 &&  tbCantHabitaciones.Text.Length != 0;
        }

        private bool determinarDisponibilidadDelPedido()
        {
           // query = "SELECT COUNT(habi_nro) AS cantDisponibles FROM FAAE.Habitacion WHERE habi_tipo_codigo = (SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "') AND habi_habilitada = 1 AND LIKE '" + regimenQueElegio + "'";
           string query = "SELECT COUNT(habi_nro) AS cantDisponibles FROM FAAE.Habitacion JOIN FAAE.Hotel ON (habi_hote_codigo = hote_codigo) JOIN FAAE.Regimen_Hotel ON (hote_codigo = reho_hote_codigo) WHERE habi_tipo_codigo = (SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "' AND habi_habilitada = 1 AND reho_regi_codigo LIKE '" + regimenQueElegio + "' AND hote_codigo = " + this.cambiarNombreHotelPorNumeroHotel().ToString();
           dataReader = DBConnection.getInstance().executeQuery(query);
           if (dataReader.Read())
           {
               return Convert.ToInt32(dataReader["cantDisponibles"].ToString()) >= Convert.ToInt32(tbCantHabitaciones.Text);
           }
           else
               return false;
        }

        private string cambiarNombreHotelPorNumeroHotel()
        {
            string query = "SELECT hote_codigo FROM FAAE.Hotel WHERE hote_nombre LIKE '" + tbNombreHotel.Text.ToString() + "'";
            
            dataReader = DBConnection.getInstance().executeQuery(query);
            if (dataReader.Read())
            {
                return dataReader["hote_codigo"].ToString();
            }
            else
                return "";
        }

        private int calcularCostoDeHabitacion()
        {
            string query = "SELECT regi_precio_base FROM FAAE.Regimen WHERE regi_nombre LIKE '" + regimenQueElegio + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            int precioRegimen = Convert.ToInt32(dataReader["regi_precio_base"].ToString());
            dataReader.Close();
            query = "SELECT tipo_cant_personas FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            int precioTipo = Convert.ToInt32(dataReader["tipo_cant_personas"].ToString());
            dataReader.Close();
            query = "SELECT hote_recarga_estrellas FROM FAAE.Hotel WHERE hote_nombre LIKE '" + tbNombreHotel + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            int precioHotel = Convert.ToInt32(dataReader["hote_recarga_estrellas"].ToString());
            dataReader.Close();
            return precioRegimen * precioTipo * precioHotel;
        }
    }

}
