using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    class Habitacion
    {
        private string numero;
        private string piso;
        private string ubicacion;
        private string tipo;
        private string descripcion;
        private string comodidades;
        private bool estaHabilitada;

        public string getNumero() { return numero; }
       // public bool getExists() { return exists; }
        //public bool getHabilitado() { return habilitado; }

        public Habitacion(string numero, string piso, string ubicacion, string tipo, string descripcion, string comodidades, bool estaHabilitada)
        {
            this.numero = numero;
            this.piso = piso;
            this.ubicacion = ubicacion;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.comodidades = comodidades;
            this.estaHabilitada = estaHabilitada;
        }
    }
}
