using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FuncionalidadesAdministrador
{
    public partial class frmFuncionalidadesAdministrador : Form
    {
        public frmFuncionalidadesAdministrador()
        {
            InitializeComponent();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            AbmCliente.frmABMCliente i = new AbmCliente.frmABMCliente();
            i.Show();
            Close();
        }

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {
            AbmUsuario.frmABMUsuario i = new AbmUsuario.frmABMUsuario();
            i.Show();
            Close();
        }

        private void btnABMHotel_Click(object sender, EventArgs e)
        {
            AbmHotel.frmAbmHotel i = new AbmHotel.frmAbmHotel();
            i.Show();
            Close();
        }

        private void btnABMHabitacion_Click(object sender, EventArgs e)
        {
            AbmHabitacion.frmAbmHabitacion i = new AbmHabitacion.frmAbmHabitacion();
            i.Show();
            Close();
        }

        private void btnABMRegimenEstadia_Click(object sender, EventArgs e)
        {
            AbmRegimen.frmAbmRegimen i = new AbmRegimen.frmAbmRegimen();
            i.Show();
            Close();
        }

        private void btnListadoEstadistico_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.frmListadoEstadistico i = new ListadoEstadistico.frmListadoEstadistico();
            i.Show();
            Close();
        }
    }
}
