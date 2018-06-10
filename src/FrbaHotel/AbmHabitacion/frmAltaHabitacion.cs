using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace FrbaHotel.AbmHabitacion
{
    public partial class frmAltaHabitacion : Form
    {
        public frmAltaHabitacion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo = this.determinarTipo(cbTipoHab.Text.ToString()); //Esto no lo deberia hacer la habitacion pero bueno...
                Habitacion habitacion = new Habitacion(Convert.ToInt32(tbNumHab.Text), Convert.ToInt32(tbcodHotel.Text), Convert.ToInt32(tbPiso.Text), Convert.ToChar(cbUbicacion.Text), tipo, tbDescripcion.Text.ToString(), rbSi.Checked);
                habitacion.guardar();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error: Hay 2 habitaciones con el mismo numero en el mismo hotel"); //revisar
            }
        }

        private int determinarTipo(string tipo) //esto deberia hacerse con un query, solo de prueba
        {
            if (tipo == "Base Simple")
            {
                return 1001;
            }
            else if (tipo == "Base Doble")
            {
                return 1002;
            }
            else if(tipo == "Base Triple")
            { 
                return 1003; 
            }
            else if (tipo == "Base Cuádruple")
            {
                return 1004;
            }
            else
            {
                return 1005;
            }

        }
               







        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaHabitación_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNumHab.Text = "";
            tbcodHotel.Text = "";
            tbPiso.Text = "";
            cbUbicacion.Text = "";
            cbTipoHab.Text = "";
            tbDescripcion.Text = "";
            rbNo.Checked = false;
            rbSi.Checked = false;
        }

        private void cbTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool camposObligatoriosCompletos()
        {
            return tbNumHab.Text.Length != 0 && tbcodHotel.Text.Length != 0 && tbPiso.Text.Length != 0 && cbUbicacion.Text.Length != 0 && cbTipoHab.Text.Length != 0;            
        }
    }
}
