using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FrbaHotel
{
    class Habitacion
    {
        private string numero;
        private string piso;
        private string ubicacion;
        private string tipo;
        private string descripcion;
        //private string comodidades;
        private bool estaHabilitada;

        public string getNumero() { return numero; }
       // public bool getExists() { return exists; }
        //public bool getHabilitado() { return habilitado; }

        public Habitacion(string numero, string piso, string ubicacion, string tipo, string descripcion, bool estaHabilitada)//, string comodidades)
        {
            this.numero = numero;
            this.piso = piso;
            this.ubicacion = ubicacion;
            this.tipo = tipo;
            this.descripcion = descripcion;
          //  this.comodidades = comodidades;
            this.estaHabilitada = estaHabilitada;
        }

        public void guardar()
        {
            string[] param = { "@habi_nro", "@habi_piso", "@habi_vista_exterior", "@habi_tipo_codigo", "@habi_habilitada" };
            object[] args = { this.numero, this.piso, this.ubicacion, this.tipo ,this.estaHabilitada };
            DBConnection.getInstance().executeProcedure("FAAE.guardar_habitacion", param, args);
            //va descripcion?
            //va comodidades?
           	// @habi_hote_codigo?cuando especifica en que hotel?
        }

        public void modificar()
        {

            string query = "SELECT habi_nro, habi_hote_codigo, habi_piso, habi_vista_exterior, habi_tipo_codigo, habi_habilitada FROM FAAE.Hotel WHERE habi_nro =" + this.numero + "AND habi_hote_codigo =";//faltaria el codigo hotel + this.;
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            if (dataReader.Read())
            {
                this.numero = dataReader["habi_nro"].ToString();
                //this.codigoHotel = dataReader["habi_hote_codigo"].ToString();
                this.piso = dataReader["habi_piso"].ToString();
                this.ubicacion = dataReader["habi_vista_exterior"].ToString();
                this.tipo = dataReader["habi_tipo_codigo"].ToString();
                this.estaHabilitada = Convert.ToBoolean(dataReader["habi_habilitada"].ToString());
            }
            dataReader.Close();
            string[] param = { "@habi_nro", "@habi_piso", "@habi_vista_exterior", "@habi_habilitada" };
            object[] args = { this.numero, this.piso, this.ubicacion ,this.estaHabilitada };
            DBConnection.getInstance().executeProcedure("FAAE.modificar_habitacion", param, args);
            //va descripcion?
            //va comodidades?
           	// @habi_hote_codigo?cuando especifica en que hotel?
        }

        public void inhabilitar()
        {
            string[] param = { "@habi_nro"};
            object[] args = { this.numero };
            DBConnection.getInstance().executeProcedure("FAAE.inhabilitar_habitacion", param, args);
            this.estaHabilitada = false;
        }


    }
}
