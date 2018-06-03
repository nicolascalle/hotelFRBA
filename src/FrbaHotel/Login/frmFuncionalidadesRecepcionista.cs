using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class frmFuncionalidadesRecepcionista : Form
    {
        public frmFuncionalidadesRecepcionista()
        {
            InitializeComponent();
        }

        private void btnGenerarModificacionReserva_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.frmGenerarModificacion i = new GenerarModificacionReserva.frmGenerarModificacion();
            i.Show();
            //Close();
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            AbmCliente.frmABMCliente i = new AbmCliente.frmABMCliente();
            i.Show();
            //Close();
        }

        private void btnRegistroConsumible_Click(object sender, EventArgs e)
        {
            RegistrarConsumible.frmRegistrarConsumible i = new RegistrarConsumible.frmRegistrarConsumible();
            i.Show();
            //Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarReserva.frmCancelarReserva i = new CancelarReserva.frmCancelarReserva();
            i.canceladaPor("Cancelada por recepcionista");
            i.Show();
            //Close();
        }

     
    }
}
