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
    public partial class frmLogin : Form  {

        public frmLogin() { InitializeComponent(); }

        private void btnSalir_Click(object sender, EventArgs e) {
            DBConnection.getInstance().getConnection().Close();
            Application.Exit(); 
        }

        private void btnIngresarHuesped_Click(object sender, EventArgs e) {
            Login.frmFuncionalidadesCliente i = new Login.frmFuncionalidadesCliente();
            i.Show();
        }

        //Cuando el usuario tiene mas de un rol se abre un formulario para selccionar el rol
        private void btnIngresar_Click(object sender, EventArgs e) {
            if ( !this.conexionCorrecta() )
                return;
            if (this.usuarioContrasenaVacios() || !this.usuarioCorrecto())
                MessageBox.Show("Usuario o contraseña incorrectos", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                Login.frmSeleccionRol sr = new frmSeleccionRol();
                sr.Show();
            }
        }

        private bool usuarioContrasenaVacios() {
            return tbUsername.Text.ToString().Length == 0 || tbPassword.Text.ToString().Length == 0;
        }

        private bool usuarioCorrecto() {
            String user, pass;
            SqlDataReader dataReader = DBConnection.getInstance()
                                                   .executeQuery("SELECT usua_username, usua_password FROM FAAE.Usuario");
            while( dataReader.Read() ) {
                user = (dataReader["usua_username"].ToString());
                pass = (dataReader["usua_password"].ToString());
                if ( user.Equals( tbUsername.Text.ToString() ) && pass.Equals( tbPassword.Text.ToString() ) ) {
                    DBConnection.getInstance().setAppUsername( user );
                    dataReader.Close();
                    return true;
                }
            }
            dataReader.Close();
            return false;
        }

        private bool conexionCorrecta() {
            try {
                DBConnection.getInstance().getConnection();
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("No se pudo conectar con la base de datos", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
