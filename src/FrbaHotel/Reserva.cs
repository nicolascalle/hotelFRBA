using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    class Reserva
    {
        private int codigo;
        private DateTime fechaRealizacion;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private int codigohotel;
        private string codigoRegimen; //?
        private string clienteDocTipo;
        private int clienteDocNro;
        private string estado;


        private string tipoHab;//falta en la tabla de sql
        private string tipoReg;//esta en la tabla reserva como "codigo" pero en la tabla regimen como "nombre"???
        private DateTime dateTime1;
        private DateTime dateTime2;
        private string p1;
        private string p2;

        public Reserva(DateTime fechaDesde, DateTime fechaHasta, string tipoHab, string tipoReg)
        {
            this.fechaRealizacion = DateTime.Now;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.tipoHab = tipoHab;
            this.tipoReg = tipoReg;
        }

        public string getRegimen()
        { return tipoReg; }


        public void guardar()
        {
            //string sqlDate = this.fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string[] param = { "@rese_fecha_realizacion", "@rese_fecha_desde", "@rese_fecha_hasta", "@rese_hote_codigo", "@rese_regi_codigo", "@rese_clie_doc_tipo", "@rese_clie_doc_nro", "@rese_estado" };
            object[] args = { this.fechaRealizacion, this.fechaDesde, this.fechaHasta, this.tipoHab, this.tipoReg, this.estado };
            DBConnection.getInstance().executeProcedure("FAAE.guardar_reserva", param, args);
        }
    }
}
