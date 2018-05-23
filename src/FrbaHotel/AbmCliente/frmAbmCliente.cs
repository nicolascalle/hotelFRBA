using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class frmABMCliente : Form
    {
        public frmABMCliente()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado i = new frmListado();
            i.Show();
        }

        private void frmAlta_Click(object sender, EventArgs e)
        {
            frmAlta i = new frmAlta();
            i.Show();
        }

        private void frmBaja_Click(object sender, EventArgs e)
        {
            frmBaja i = new frmBaja();
            i.Show();
        }

        private void frmModificacion_Click(object sender, EventArgs e)
        {
            frmModificacion i = new frmModificacion();
            i.Show();
        }

    }
}
