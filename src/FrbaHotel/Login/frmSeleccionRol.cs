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
                                                   .executeQuery("SELECT rol_nombre FROM FAAE.RolXUsuario WHERE username ='" + DBConnection.getInstance().getUsuario().getUsername() + "'");
            while( dataReader.Read() ) 
                this.cbListaRoles.Items.Add( dataReader["rol_nombre"].ToString() );

            dataReader.Close();
        }

        private void continuar_Click(object sender, EventArgs e) {
            String seleccion = this.cbListaRoles.Text.ToString();
            if (seleccion.Equals("admin")) {
                Login.frmFuncionalidadesAdministrador i = new Login.frmFuncionalidadesAdministrador();
                i.Show();
                Close();
            }
            else if (seleccion.Equals("recepcion")) {
                Login.frmFuncionalidadesRecepcionista i = new Login.frmFuncionalidadesRecepcionista();
                i.Show();
                Close();            
            }
        }

    }
}
