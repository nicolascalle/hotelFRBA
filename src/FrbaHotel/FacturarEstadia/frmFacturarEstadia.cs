using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FacturarEstadia
{
    public partial class frmFacturarEstadia : Form
    {
        public frmFacturarEstadia()
        {
            InitializeComponent();
        }

        private void btnFacturarEstadia_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarConsumibles_Click(object sender, EventArgs e)
        {
            RegistrarConsumible.frmRegistrarConsumible i = new RegistrarConsumible.frmRegistrarConsumible();
            i.Show();
        }
    }
}
