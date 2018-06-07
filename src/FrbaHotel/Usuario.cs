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
        private bool exists;
        private bool habilitado;

        public string getUsername() { return username; }
        public bool getExists() { return exists; }
        public bool getHabilitado() { return habilitado; }

        public Usuario(string username, string password) {
            this.username = username;
            this.password = password;
            this.exists = false;
            this.habilitado = false;
        }

        public Usuario(string username) {
            this.username = username;
            this.password = "";
            this.exists = false;
            this.habilitado = false;
        }

        private void limpiarLoginFallidos() {
            string[] param = { "@username" };
            string[] args = { this.username };
            DBConnection.getInstance().executeProcedure("limpiar_login_fallidos", param, args);
        }

        private void registrarLoginFallido() {
            string[] param = { "@username" };
            string[] args = { this.username };
            DBConnection.getInstance().executeProcedure("login_fallido", param, args);
        }

        private bool estaHabilitado() {
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT usua_habilitado FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'");
            dataReader.Read();
            this.habilitado = dataReader["usua_habilitado"].Equals(true);
            dataReader.Close();
            return this.habilitado;
        }

        public void ingresar() {
            if(this.usernamePasswordCorrectos()) {
                if(this.estaHabilitado())
                    this.limpiarLoginFallidos();
            }
            else
                this.registrarLoginFallido();
        }

        public bool ingresoCorrectamente() {
            return this.exists && this.estaHabilitado();
        }

        private bool usernamePasswordCorrectos() {
            String user, pass;
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT usua_username, usua_password FROM FAAE.Usuario");

            while (dataReader.Read()) {

                user = (dataReader["usua_username"].ToString());
                pass = (dataReader["usua_password"].ToString());

                if ( this.coincide(user, pass) ) {
                    dataReader.Close();
                    return this.exists = true;
                }
            }

            dataReader.Close();
            return this.exists = false;
        }

        private bool coincide(string usuario, string contrasena) {
            return usuario.Equals(this.username) && contrasena.Equals(this.password);
        }

        public void inhabilitar() {
            string[] param = { "@username" };
            object[] args = { this.username };
            DBConnection.getInstance().executeProcedure("inhabilitar_usuario", param, args);
            this.habilitado = false;
        }
    }
}
