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
    public partial class frmBajaHabitacion : Form
    {
        public frmBajaHabitacion()
        {
            InitializeComponent();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM FAAE.Habitacion WHERE habi_nro = " + tbNumHab.Text.ToString() + "AND habi_hote_codigo = " + tbcodHotel.Text.ToString();
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            if (dataReader.Read())
            {
                frmAdvertenciaBaja ventanaBaja = new frmAdvertenciaBaja(tbNumHab.Text.ToString(), tbcodHotel.Text.ToString());
                ventanaBaja.Show();
                dataReader.Close();
            }
            else
                MessageBox.Show("Error: No existe esa habitacion");

            dataReader.Close();
        }
    }
}
