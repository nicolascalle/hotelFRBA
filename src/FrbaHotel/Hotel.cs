using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    public class Hotel {

        private int codigo;
        private string nombre;
        private short estrellas;
        private string ciudad;
        private string pais;
        private string mail;
        private string telefono;
        private string dire_calle;
        private string dire_nro;
        private DateTime fechaCreacion;
        private double recargaEstrellas;

        public Hotel() { this.codigo = 0; }
        public Hotel(int codigo) { this.codigo = codigo; }

        public string getNombre() { return this.nombre; }
        public short getEstrellas() { return this.estrellas; }
        public string getCiudad() { return this.ciudad; }
        public string getPais() { return this.pais; }
        public string getMail() { return this.mail; }
        public string getTelefono() { return this.telefono; }
        public string getDire_calle() { return this.dire_calle; }
        public string getDire_nro() { return this.dire_nro; }
        public DateTime getFechaCreacion() { return this.fechaCreacion; }
        public double getRecargaEstrellas() { return this.recargaEstrellas; }

        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setEstrellas(short estrellas) { this.estrellas = estrellas; }
        public void setCiudad(string ciudad) { this.ciudad = ciudad; }
        public void setPais(string pais) { this.pais = pais; }
        public void setMail(string mail) { this.mail = mail; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setDire_calle(string dire_calle) { this.dire_calle = dire_calle; }
        public void setDire_nro(string dire_nro) { this.dire_nro = dire_nro; }
        public void setFechaCreacion(DateTime fechaCreacion) { this.fechaCreacion = fechaCreacion; }
        public void setRecargaEstrellas(double recargaEstrellas) { this.recargaEstrellas = recargaEstrellas; }

        public void buscar() {

            string query = "SELECT hote_codigo, hote_nombre, hote_mail, hote_telefono, hote_dire_calle, hote_dire_nro, hote_cant_estrellas, hote_ciudad, hote_pais, hote_fecha_creacion, hote_recarga_estrellas FROM FAAE.Hotel WHERE hote_codigo =" + this.codigo;
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            if (dataReader.Read()) {

                this.nombre = dataReader["hote_nombre"].ToString();
                this.estrellas = Convert.ToInt16(dataReader["hote_cant_estrellas"].ToString());
                this.ciudad = dataReader["hote_ciudad"].ToString();
                this.pais = dataReader["hote_pais"].ToString();
                this.mail = dataReader["hote_mail"].ToString();
                this.telefono = dataReader["hote_telefono"].ToString();
                this.dire_calle = dataReader["hote_dire_calle"].ToString();
                this.dire_nro = dataReader["hote_dire_nro"].ToString();
                this.fechaCreacion = Convert.ToDateTime(dataReader["hote_fecha_creacion"].ToString());
                this.recargaEstrellas = Convert.ToDouble(dataReader["hote_recarga_estrellas"].ToString());
            }

            dataReader.Close();
        }

        public void eliminar() {
            string[] param = { "@hote_codigo" };
            object[] args = { this.codigo };
            DBConnection.getInstance().executeProcedure("eliminar_hotel", param, args);
        }

        // Si no existe el hotel lo crea, si existe lo actualiza
        public void guardar() {
            string sqlDate = this.fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string[] param = { "@hote_codigo", "@hote_nombre", "@hote_mail", "@hote_telefono", "@hote_dire_calle", "@hote_dire_nro", "@hote_cant_estrellas", "@hote_ciudad", "@hote_pais", "@hote_fecha_creacion", "@hote_recarga_estrellas" };
            object[] args = { this.codigo, this.nombre, this.mail, this.telefono, this.dire_calle, this.dire_nro, this.estrellas, this.ciudad, this.pais, sqlDate, this.recargaEstrellas };
            DBConnection.getInstance().executeProcedure("guardar_hotel", param, args);
        } // El hote_codigo es identity

    }
}
