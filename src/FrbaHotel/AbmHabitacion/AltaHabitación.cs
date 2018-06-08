using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class AltaHabitación : Form
    {
        public AltaHabitación()
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
            this.Close();
            bool situacionHabilitacion = rbSi.Checked;
            Habitacion habitacion = new Habitacion(tbNumHab.Text.ToString(), tbPiso.Text.ToString(), cbUbicacion.Text.ToString(), cbTipoHab.Text.ToString(), tbDescripcion.Text.ToString(), tbComodidades.Text.ToString(), situacionHabilitacion);
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
            tbComodidades.Text = "";
            tbDescripcion.Text = "";
            tbNumHab.Text = "";
            tbPiso.Text = "";
            cbTipoHab.Text = "";
            cbUbicacion.Text = "";

        }

        private void cbTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
