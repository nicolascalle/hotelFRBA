﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrbaHotel {
    public class Usuario {

        private string docTipo;
        private long docNro;
        private string username;
        private string password;
        private string nombre;
        private string apellido;
        private string mail;
        private string telefono;
        private string direCalle;
        private int direNro;
        private DateTime fechaNacimiento;
        private int loginFallidos;
        private long hotelUltimoLogin;
        private bool habilitado;
        List<string> roles;
        private bool exists;

        public string getDocTipo() { return docTipo; }
        public long getDocNro() { return docNro; }
        public string getUsername() { return username; }
        public string getPassword() { return password; }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public string getMail() { return mail; }
        public string getTelefono() { return telefono; }
        public string getDireCalle() { return direCalle; }
        public int getDireNro() { return direNro; }
        public DateTime getFechaNacimiento() { return fechaNacimiento; }
        public int getLoginFallidos() { return loginFallidos; }
        public long getHotelUltimoLogin() { return hotelUltimoLogin; }
        public bool getHabilitado() { return habilitado; }
        public List<string> getRoles() { return roles; }
        public bool getExists() { return exists; }

        public void setDocTipo(string docTipo) { this.docTipo = docTipo; }
        public void setDocNro(long docNro) { this.docNro = docNro; }
        public void setUsername(string username) { this.username = username; }
        public void setPassword(string password) { this.password = password; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public void setMail(string mail) { this.mail = mail; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setDireCalle(string direCalle) { this.direCalle = direCalle; }
        public void setDireNro(int direNro) { this.direNro = direNro; }
        public void setFechaNacimiento(DateTime fechaNacimiento) { this.fechaNacimiento = fechaNacimiento; }
        public void setHotelUltimoLogin(long hotelUltimoLogin) { this.hotelUltimoLogin = hotelUltimoLogin; }
        public void setHabilitado(bool habilitado) { this.habilitado = habilitado; }
        public void agregarRol(string rol) { this.roles.Add(rol); }
        public void limpiarRoles() { this.roles = new List<string>(); }

        public Usuario(string username) {
            this.username = username;
            this.password = "";
            this.loginFallidos = 0;
            this.habilitado = false;
            this.roles = new List<string>();
            this.exists = false;
        }

        public Usuario(string username, string password) {
            this.username = username;
            this.password = password;
            this.habilitado = false;
            this.roles = new List<string>();
            this.exists = false;
        }

        private bool estaHabilitado() {
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT usua_habilitado FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'");
            dataReader.Read();
            this.habilitado = dataReader["usua_habilitado"].Equals(true);
            dataReader.Close();
            return this.habilitado;
        }

        public bool tieneUsernameUnico() {
            bool usernameUnico;
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT COUNT(*) existencias FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'");
            dataReader.Read();
            usernameUnico = (int)dataReader["existencias"] == 0;
            dataReader.Close();
            return usernameUnico;
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

        private void limpiarLoginFallidos() {
            string[] param = { "@username" };
            string[] args = { this.username };
            DBConnection.getInstance().executeProcedure("FAAE.limpiar_login_fallidos", param, args);
        }

        private void registrarLoginFallido() {
            string[] param = { "@username" };
            string[] args = { this.username };
            DBConnection.getInstance().executeProcedure("FAAE.login_fallido", param, args);
        }

        private bool coincide(string usuario, string contrasena) {
            return usuario.Equals(this.username) && contrasena.Equals(this.password);
        }

        public void inhabilitar() {
            string[] param = { "@username" };
            object[] args = { this.username };
            DBConnection.getInstance().executeProcedure("FAAE.inhabilitar_usuario", param, args);
            this.habilitado = false;
        }

        public void buscar() {
            string query = "SELECT usua_doc_tipo, usua_doc_nro, usua_username, usua_password, usua_nombre, usua_apellido, usua_mail, usua_telefono, usua_dire_calle, usua_dire_nro, usua_fecha_nacimiento, usua_cant_log_in_fallidos, usua_hote_codigo_ultimo_log_in, usua_habilitado";
            query += " FROM FAAE.Usuario WHERE usua_username = '" + this.username + "'";
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            if (dataReader.Read()) {
                this.docTipo = dataReader["usua_doc_tipo"].ToString();
                this.docNro = Convert.ToInt64(dataReader["usua_doc_nro"].ToString());
                this.username = dataReader["usua_username"].ToString();
                this.password = dataReader["usua_password"].ToString();
                this.nombre = dataReader["usua_nombre"].ToString();
                this.apellido = dataReader["usua_apellido"].ToString();
                this.mail = dataReader["usua_mail"].ToString();
                this.telefono = dataReader["usua_telefono"].ToString();
                this.direCalle = dataReader["usua_dire_calle"].ToString();
                this.direNro = Convert.ToInt32(dataReader["usua_dire_nro"].ToString());
                this.fechaNacimiento = Convert.ToDateTime(dataReader["usua_fecha_nacimiento"].ToString());
                this.loginFallidos = Convert.ToInt16(dataReader["usua_cant_log_in_fallidos"].ToString());
                this.hotelUltimoLogin = Convert.ToInt64(dataReader["usua_hote_codigo_ultimo_log_in"].ToString());
                this.habilitado = dataReader["usua_habilitado"].Equals(true);
                this.exists = true;
            }
            dataReader.Close();

            query = "SELECT rous_rol_nombre FROM FAAE.Rol_Usuario WHERE rous_clie_doc_tipo = '" + this.docTipo + "' AND rous_clie_doc_nro = " + this.docNro;
            dataReader = DBConnection.getInstance().executeQuery(query);

            while (dataReader.Read())
                this.roles.Add(dataReader["rous_rol_nombre"].ToString());

            dataReader.Close();
        }

        public void guardar() {
            string sqlDate = this.fechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string[] param1 = { "@usua_doc_tipo", "@usua_doc_nro", "@usua_username", "@usua_password", "@usua_nombre", "@usua_apellido", "@usua_mail", "@usua_telefono", "@usua_dire_calle", "@usua_dire_nro", "@usua_fecha_nacimiento", "@usua_cant_log_in_fallidos", "@usua_hote_codigo_ultimo_log_in", "@usua_habilitado" };
            object[] args1 = { this.docTipo, this.docNro, this.username, this.password, this.nombre, this.apellido, this.mail, this.telefono, this.direCalle, this.direNro, sqlDate, this.loginFallidos, this.hotelUltimoLogin, this.habilitado };
            DBConnection.getInstance().executeProcedure("FAAE.guardar_usuario", param1, args1);

            string[] param2 = { "@usua_username" };
            object[] args2 = { this.username };
            DBConnection.getInstance().executeProcedure("FAAE.eliminar_roles_usuario", param2, args2);

            string[] param3 = { "@usua_username", "@rol_nombre" };
            this.roles.ForEach(rol => {
                object[] args3 = { this.username, rol };
                DBConnection.getInstance().executeProcedure("FAAE.asignar_rol_usuario", param3, args3);
            });
        }

    }
}
