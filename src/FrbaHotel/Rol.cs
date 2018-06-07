using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    class Rol {

        private string nombre;
        private bool habilitado;

        public Rol(string nombre) {
            this.nombre = nombre;
            this.habilitado = false;
        }

        public void inhabilitar() {
            string[] param = { "@nombre" };
            object[] args = { this.nombre };
            DBConnection.getInstance().executeProcedure("inhabilitar_rol", param, args);
            this.habilitado = false;
        }


    }
}
