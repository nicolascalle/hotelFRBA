using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmModificarReserva : Form
    {
        string numeroReserva;
        SqlDataReader dataReader;        
        public frmModificarReserva(string numeroReserva)
        {
            InitializeComponent();
            this.numeroReserva = numeroReserva;
            this.mostrarReserva();
            tbNombreHotel.Enabled = false;
        }

        private void mostrarReserva()
        {
            tbNumeroDeReserva.Text = numeroReserva;
            string query = "SELECT * FROM FAAE.Reserva WHERE rese_codigo = " + this.numeroReserva;
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();//no es necesario controlar, lo hace la anterior ventana

                tbNombreHotel.Text = dataReader["rese_hote_codigo"].ToString();
                dtFechaInicioReserva.Value = Convert.ToDateTime(dataReader["rese_fecha_desde"]);
                dtFechaFinalReserva.Value = Convert.ToDateTime(dataReader["rese_fecha_hasta"]);
                cbTipoRegimen.Text = dataReader["rese_regi_codigo"].ToString();
                dataReader.Close();//no es necesario controlar
                //JOIN para saber de que tipo es la reserva 
                query = "SELECT DISTINCT tipo_descripcion FROM FAAE.Reserva_Habitacion JOIN FAAE.Habitacion ON (reha_habi_nro = habi_nro AND reha_hote_codigo = habi_hote_codigo)  JOIN FAAE.Tipo ON (tipo_codigo = habi_tipo_codigo) WHERE reha_rese_codigo = " + this.numeroReserva;
                dataReader = DBConnection.getInstance().executeQuery(query);
                dataReader.Read();
                cbTipoHab.Text = dataReader["tipo_descripcion"].ToString();
                dataReader.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] param = { "@rese_codigo", "@rese_fecha_desde", "@rese_fecha_hasta", "@rese_regi_codigo" };
            object[] args = { this.numeroReserva, dtFechaInicioReserva.Value, dtFechaFinalReserva.Value, cbTipoRegimen.Text.ToString()};//, //this.tipoReg };, this.tipoHab };, this.estado };
            DBConnection.getInstance().executeProcedure("FAAE.modificar_reserva", param, args);
            
            string[] param2 = { "@rese_codigo" };
            object[] args2 = { this.numeroReserva };
            DBConnection.getInstance().executeProcedure("FAAE.borrar_habitacionesDeReservaAntigua", param2, args2);

            this.generarNuevasReservas();

            MessageBox.Show("Se modifico satisfactoriamente");
            this.Close();
        }

        private void generarNuevasReservas()
        {

        }

        private bool determinarDisponibilidadDelPedido()
        {
            string query = "SELECT COUNT(habi_nro) AS cantDisponibles FROM FAAE.Habitacion JOIN FAAE.Hotel ON (habi_hote_codigo = hote_codigo) JOIN FAAE.Regimen_Hotel ON (hote_codigo = reho_hote_codigo) WHERE habi_tipo_codigo = (SELECT tipo_codigo FROM FAAE.Tipo WHERE tipo_descripcion LIKE '" + cbTipoHab.Text.ToString() + "') AND habi_habilitada = 1 AND reho_regi_codigo LIKE '" + cbTipoRegimen.Text.ToString() + "' AND hote_codigo = " + tbNombreHotel.Text.ToString() + " AND NOT exists (SELECT NULL FROM FAAE.Reserva_Habitacion WHERE reha_hote_codigo = hote_codigo  AND habi_nro = reha_habi_nro)";
            dataReader = DBConnection.getInstance().executeQuery(query);
            if (dataReader.Read())
            {
                bool hayDisponibilidad = Convert.ToInt32(dataReader["cantDisponibles"].ToString()) >= Convert.ToInt32(this.calcularCantidadHabitaciones());
                dataReader.Close();
                return hayDisponibilidad;
            }
            else
                dataReader.Close();
            return false;
        }

        private int calcularCantidadHabitaciones()
        {
            string query = "SELECT COUNT(reha_habi_nro) cantDeHabitaciones FROM FAAE.Reserva_Habitacion WHERE reha_rese_codigo = " + numeroReserva;
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            int cantHab = Convert.ToInt32(dataReader["cantDeHabitaciones"]);
            dataReader.Close();
            return cantHab;
        }


    }
}
