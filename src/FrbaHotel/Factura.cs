﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel {
    public class Factura {

        string tipo;
        string nro;
        DateTime fecha;
        string reservaNro;
        string formaDePago;
        string hotelNombre;
        string nombreCliente;
        List<Item> items;
        decimal total;

        public string getTipo() { return this.tipo; }
        public string getNro() { return this.nro; }
        public DateTime getFecha() { return this.fecha; }
        public string getReservaNro() { return this.reservaNro; }
        public string getFormaDePago() { return this.formaDePago; }
        public string getHotelNombre() { return this.hotelNombre; }
        public string getNombreCliente() { return this.nombreCliente; }
        public decimal getTotal() { return this.total; }
        public List<Item> getItems() { return this.items; }

        public void agregarItem(Item i) { items.Add(i); }

        public Factura(string reservaNro, string formaDePago) {
            this.reservaNro = reservaNro;
            this.formaDePago = formaDePago;
            this.items = new List<Item>() { };
        }

        public void generar() {
            string query = "SELECT fact_tipo, fact_nro, fact_fecha, fact_forma_pago, hote_nombre, nombreApellido";
            query += " FROM FAAE.NuevaFactura(" + this.reservaNro + ")";
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            if (dataReader.Read()) {
                this.tipo = dataReader["fact_tipo"].ToString();
                this.nro = dataReader["fact_nro"].ToString();
                this.fecha = DateTime.Now;
                this.hotelNombre = dataReader["hote_nombre"].ToString();
                this.nombreCliente = dataReader["nombreApellido"].ToString();
            }
            dataReader.Close();
            this.total = this.calcularTotalEstadia() + this.calcularTotalConsumibles();
        }

        public decimal calcularTotalEstadia() {
            decimal totalEstadia;
            string query = "SELECT FAAE.calcularTotalEstadia(" + this.reservaNro + ") " + "totalEstadia";
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            totalEstadia = (decimal)dataReader["totalEstadia"];
            dataReader.Close();
            return totalEstadia;
        }

        public decimal calcularTotalConsumibles() {
            return this.items.Sum(item => item.total());
        }

        public void guardar() {
            string[] param1 = { "@fact_tipo", "@fact_nro", "fact_fecha", "fact_total", "fact_rese_codigo" };
            object[] args1 = { this.tipo, this.nro, this.fecha, this.total, this.reservaNro };
            DBConnection.getInstance().executeProcedure("FAAE.guardar_factura", param1, args1);

            string[] param2 = { "@fact_tipo", "@fact_nro", "@item_cons_codigo", "@cantidad", "@precio" };
            this.items.ForEach(item => {
                object[] args2 = { this.tipo, this.nro, item.getCodigo(), item.getCantidad(), item.getPrecioUnitario() };
                DBConnection.getInstance().executeProcedure("FAAE.guardar_items_factura", param2, args2);
            });
        }

    }
}