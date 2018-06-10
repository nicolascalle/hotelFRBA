﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.AbmHabitacion
{
    public partial class frmAbmHabitacion : Form
    {
        public frmAbmHabitacion()
        {
            InitializeComponent();
            this.setLvProperties();
        }

        private void frmAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaHabitación ventanaAlta = new AltaHabitación();
            ventanaAlta.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lvHabitaciones.Items.Clear();
            string query = this.generateQuery();
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            while (dataReader.Read())
            {
                ListViewItem listItem = this.nuevoItem(dataReader);
                this.lvHabitaciones.Items.Add(listItem);
            }
            dataReader.Close();
        }

        private string generateQuery()
        {
            string query = "SELECT * FROM FAAE.Habitacion";
            string numeroHabitacion = tbNumeroHabitacion.Text.ToString();
            string codigoHotel = tbCodigoHotel.Text.ToString();
            string piso = tbPiso.Text.ToString();
            string tieneVistaExterior =  tbVistaExterior.Text.ToString();

            if (this.seIngresaronDatos()) //se controla si se ingresó algo y no esta vacio, asi no se agrega el "where" al query final
            {
                List<string> conditions = new List<string>();

                if (numeroHabitacion.Length != 0)
                    conditions.Add("habi_nro = " + numeroHabitacion);
                if (codigoHotel.Length != 0)
                    conditions.Add("habi_hote_codigo = " + codigoHotel);
                if (piso.Length != 0)
                    conditions.Add("habi_piso =" + piso);
                if (tieneVistaExterior.Length != 0)
                    conditions.Add("habi_vista_exterior LIKE '" + tieneVistaExterior + "'");
                if (rbSi.Checked)
                {
                    conditions.Add("habi_habilitada = 1");
                    rbSi.Checked = false;
                }
                if (rbNo.Checked)
                {
                    conditions.Add("habi_habilitada = 0");
                    rbNo.Checked = false;
                }

                query += " WHERE ";
                foreach (var condition in conditions)
                    query += condition + " AND ";
                query = query.Substring(0, query.Length - " AND ".Length);
            }

            return query;
        }
        private bool seIngresaronDatos()
        {
            return tbNumeroHabitacion.Text.ToString().Length != 0 || tbCodigoHotel.Text.ToString().Length != 0 || tbPiso.Text.ToString().Length != 0 || tbVistaExterior.Text.ToString().Length != 0 || rbSi.Checked || rbNo.Checked;

        }

        public ListViewItem nuevoItem(SqlDataReader dataReader)//setea que atributo estará en cada columna del lv
        {
            ListViewItem listItems = new ListViewItem(dataReader["habi_nro"].ToString());
            listItems.SubItems.Add(dataReader["habi_hote_codigo"].ToString());
            listItems.SubItems.Add(dataReader["habi_piso"].ToString());
            listItems.SubItems.Add(dataReader["habi_vista_exterior"].ToString());
            listItems.SubItems.Add(dataReader["habi_tipo_codigo"].ToString());
            listItems.SubItems.Add(dataReader["habi_habilitada"].ToString());
            listItems.SubItems.Add(dataReader["habi_descripcion"].ToString());
            return listItems;
        }

        private void lvHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void setLvProperties()//seteando el nombre de las columnas
        {
            this.lvHabitaciones.Columns.Add("Numero");
            this.lvHabitaciones.Columns.Add("Numero de Hotel");
            this.lvHabitaciones.Columns.Add("Piso");
            this.lvHabitaciones.Columns.Add("Tiene Vista exterior");
            this.lvHabitaciones.Columns.Add("Codigo del Tipo");
            this.lvHabitaciones.Columns.Add("Esta habilitada");
            this.lvHabitaciones.View = View.Details;
            this.lvHabitaciones.MultiSelect = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
