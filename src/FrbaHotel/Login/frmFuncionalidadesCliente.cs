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
    public partial class frmFuncionalidadesCliente : Form
    {
        public frmFuncionalidadesCliente()
        {
            InitializeComponent();
        }

        private void btnGenerarModificacionReserva_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.frmGenerarModificacion i = new GenerarModificacionReserva.frmGenerarModificacion();
            i.Show();
            Close();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            CancelarReserva.frmCancelarReserva i = new CancelarReserva.frmCancelarReserva();
            i.canceladaPor("Cancelada por cliente");
            i.Show();
            Close();
        }


    }
}
