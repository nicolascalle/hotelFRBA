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

namespace FrbaHotel.AbmHabitacion
{
    public partial class frmSeleccionarHabitacion : Form
    {
        public frmSeleccionarHabitacion()
        {
            InitializeComponent();
        }

        private void frmModificarHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM FAAE.Habitacion WHERE habi_nro = " + tbNumHab.Text.ToString() + "AND habi_hote_codigo = " + tbcodHotel.Text.ToString();
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            if (dataReader.Read())
            {
                frmModificarHabitacion ventanaModificar = new frmModificarHabitacion(tbNumHab.Text.ToString(), tbcodHotel.Text.ToString(), dataReader);
                ventanaModificar.Show();
                this.Close();

            }
            else
                MessageBox.Show("Error: No existe esa habitacion");

            dataReader.Close();
            
        }

        private void tbcodHotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbNumHab_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
