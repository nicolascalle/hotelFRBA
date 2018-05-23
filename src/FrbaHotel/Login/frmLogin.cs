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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresarHuesped_Click(object sender, EventArgs e)
        {
            FuncionalidadesCliente.frmFuncionalidadesCliente i = new FuncionalidadesCliente.frmFuncionalidadesCliente();
            i.Show();
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)//Cuando el usuario tiene mas de un rol se abre un formulario para selccionar el rol
        {
            FuncionalidadesAdministrador.frmFuncionalidadesAdministrador i = new FuncionalidadesAdministrador.frmFuncionalidadesAdministrador();
            i.Show();
            Close();
        }

    }
}
