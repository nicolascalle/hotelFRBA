using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    class Consumible {

        String nombre;
        double precio;
        bool exists;

        public Consumible(string nombre, double precio) {
            this.nombre = nombre;
            this.precio = precio;
            this.exists = false;
        }

        public void registrar() { 
            string[] param = { "@nombre", "@precio" };
            object[] args = { this.nombre, this.precio };
            try {
                //DBConnection.getInstance().executeProcedure("registrar_consumible", param, args);
            }
            catch { this.exists = true; }
        }

        public bool seRegistroCorrectamente() {
            return !this.exists;
        }

    }
}
