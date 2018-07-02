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
    public partial class frmSeleccionarReserva : Form
    {
        SqlDataReader dataReader;
        public frmSeleccionarReserva()
        {
            InitializeComponent();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            this.existeReserva();
        }

        private void existeReserva()
        {
            string query = "SELECT rese_codigo FROM FAAE.Reserva WHERE rese_codigo = " + tbNumReserva.Text.ToString();
            dataReader = DBConnection.getInstance().executeQuery(query);
            if (dataReader.Read())
            {
                dataReader.Close();
                frmModificarReserva ventanaModificar = new frmModificarReserva(tbNumReserva.Text.ToString());
                ventanaModificar.Show();
            }
            else
            {
                dataReader.Close();
                MessageBox.Show("No existe esa reserva", "Error codigo reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
