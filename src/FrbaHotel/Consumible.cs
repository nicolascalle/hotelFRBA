using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    class Consumible {

        int codigo;
        String descripcion;
        double precio;
        bool exists;

        public Consumible(int codigo, double precio, string descripcion) {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.exists = false;
        }

        public void registrar() {
            string[] param = { "@codigo", "@precio", "@descipcion" };
            object[] args = { this.codigo, this.precio, this.descripcion };
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
