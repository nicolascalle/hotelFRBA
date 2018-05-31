using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrbaHotel {
    class Usuario {

        private string username;
        private string password;

        public string getUsername() { return username; }

        public Usuario(string username, string password) {
            this.username = username;
            this.password = password;
        }

        private void limpiarLoginFallidos() { 
        }

        private void registrarLoginFallido() {

        }

        public bool estaHabilitado() {
            bool habilitado;
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT usua_habilitado FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'");
            dataReader.Read();
            habilitado = dataReader["usua_habilitado"].Equals(true);
            dataReader.Close();
            return habilitado;
        }


        public bool registrarIngresoOK() {

            if (this.usernamePasswordCorrectos())
                return this.registrarIngresoCorrecto();
            else
                return this.registrarIngresoIncorrecto();
        }

        private bool usernamePasswordCorrectos() {
            String user, pass;
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT usua_username, usua_password FROM FAAE.Usuario");

            while (dataReader.Read()) {

                user = (dataReader["usua_username"].ToString());
                pass = (dataReader["usua_password"].ToString());

                if ( this.coincide(user, pass) ) {
                    dataReader.Close();
                    return true;
                }
            }

            dataReader.Close();
            return false;
        }

        private bool registrarIngresoIncorrecto() {

            this.registrarLoginFallido();
            return false;
        }

        private bool registrarIngresoCorrecto() {

            if (this.estaHabilitado()) {
                this.limpiarLoginFallidos();
                return true;
            }
            return false;
        }

        private bool coincide(string usuario, string contrasena) {
            return usuario.Equals(this.username) && contrasena.Equals(this.password);
        }

    }
}
