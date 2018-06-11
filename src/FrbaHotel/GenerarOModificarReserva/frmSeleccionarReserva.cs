using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmSeleccionarReserva : Form
    {
        public frmSeleccionarReserva()
        {
            InitializeComponent();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            frmModificarRserva ventanaModificar = new frmModificarRserva();
            ventanaModificar.Show();
        }
    }
}
