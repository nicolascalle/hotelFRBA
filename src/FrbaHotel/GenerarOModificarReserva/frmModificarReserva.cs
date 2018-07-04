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
           // string[] param = { "@", "@rese_fecha_desde", "@rese_fecha_hasta", "@rese_hote_codigo" };//, "@rese_regi_codigo" , "@rese_clie_doc_tipo", "@rese_clie_doc_nro", "@rese_clie_mail" };
            //[] args = { tbNumeroDeReserva.Text, dtFechaInicioReserva, dtFechaFinalReserva, tbNombreHotel.Text };//, //this.tipoReg };, this.tipoHab };, this.estado };
           // DBConnection.getInstance().executeProcedure("FAAE.modificar_reserva", param, args);
            this.Close();
        }


    }
}
