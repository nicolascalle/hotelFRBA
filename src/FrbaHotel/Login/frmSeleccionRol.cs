using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.Login {
    public partial class frmSeleccionRol : Form {

        public frmSeleccionRol() { 
            InitializeComponent();
            this.agregarRolesDisponibles();
        }

        private void agregarRolesDisponibles() {
            SqlDataReader dataReader = DBConnection.getInstance()
                                       .executeQuery("SELECT rol_nombre FROM FAAE.RolXUsuario WHERE username ='" + DBConnection.getInstance().getAppUsername() + "'");
            while( dataReader.Read() ) {
                this.cbListaRoles.Items.Add( dataReader["rol_nombre"].ToString() );
            }
            dataReader.Close();
        }

        // Tendria que abrir distintas ventanas de funcionalidades segun el Rol elegido en el ComboBox
        private void continuar_Click(object sender, EventArgs e) {
            FuncionalidadesAdministrador.frmFuncionalidadesAdministrador i = new FuncionalidadesAdministrador.frmFuncionalidadesAdministrador();
            i.Show();
            Close();
        }

    }
}
