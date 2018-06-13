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
                if (cbTipoRegimen.Text.Length != 0)
                {
                    if (this.determinarDisponibilidadDelPedido())
                    {
                        MessageBox.Show("hay disponibilidad");
                        //Reserva nuevaReserva = new Reserva(dtFechaInicioReserva.Value, dtFechaFinalReserva.Value, cbTipoHab.Text.ToString(), cbTipoRegimen.Text.ToString()); //Convert.ToInt32(cbTipoHab.Text.ToString()), 
                        //nuevaReserva.guardar();
                    }
                    else
                        MessageBox.Show("No hay disponibilidad");
                }
                else
                {
                   
                   frmEleccionDeRegimen ventanaEleccion = new frmEleccionDeRegimen(this.cambiarNombreHotelPorNumeroHotel());
                   dataReader.Close();
                   ventanaEleccion.Show();
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
           string query = "SELECT COUNT(habi_nro) AS cantDisponibles FROM FAAE.Habitacion WHERE habi_tipo_codigo = (SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "')";
           SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);
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
    }

}
