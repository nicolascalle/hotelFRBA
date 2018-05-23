using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FuncionalidadesRecepcionista
{
    public partial class frmFuncionalidadesRecepcionista : Form
    {
        public frmFuncionalidadesRecepcionista()
        {
            InitializeComponent();
        }

        private void btnGenerarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnABMClientes_Click(object sender, EventArgs e)
        {
            AbmUsuario.frmABMUsuario i = new AbmUsuario.frmABMUsuario();
            i.Show();
            Close();
        }

        private void btnRegistrarEstadia_Click(object sender, EventArgs e)
        {
            RegistrarEstadia.frmRegistrarEstadia i = new RegistrarEstadia.frmRegistrarEstadia();
            i.Show();
            Close();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            CancelarReserva.frmCancelarReserva i = new CancelarReserva.frmCancelarReserva();
            i.Show();
            Close();
        }
    }
}
