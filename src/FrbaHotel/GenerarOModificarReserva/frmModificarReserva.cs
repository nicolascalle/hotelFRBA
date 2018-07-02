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
            dataReader.Read();
            tbNombreHotel.Text = dataReader["rese_hote_codigo"].ToString();
            dtFechaInicioReserva.Value = Convert.ToDateTime(dataReader["rese_fecha_desde"]);
            dtFechaFinalReserva.Value = Convert.ToDateTime(dataReader["rese_fecha_hasta"]);
            cbTipoRegimen.Text = dataReader["rese_regi_codigo"].ToString();
            dataReader.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
