﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario {
    public partial class frmABMUsuario : Form {

        public frmABMUsuario() {
            InitializeComponent();
            this.setLvProperties();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            this.lvUsuarios.Items.Clear();
            string query = this.generateQuery();
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader);
                this.lvUsuarios.Items.Add(listItem);
            }
            dataReader.Close();

        }

        private void frmInhabilitar_Click(object sender, EventArgs e) {
            if (this.lvUsuarios.SelectedItems.Count == 1) {
                string username = this.lvUsuarios.SelectedItems[0].Text.ToString();
                new Usuario(username).inhabilitar();
            }
        }

        private void frmAlta_Click(object sender, EventArgs e) {

        }

        private void frmModificacion_Click(object sender, EventArgs e) {

        }

        private string generateQuery() {

            string query = "SELECT usua_username, usua_apellido, usua_nombre, usua_mail, usua_habilitado FROM FAAE.Usuario";
            string username = tbUsername.Text.ToString();

            if (this.seIngresaronDatos()) {
                List<string> conditions = new List<string>();

                if (username.Length != 0)
                    conditions.Add("usua_username LIKE '%" + username + "%'");

                query += " WHERE ";
                foreach (var condition in conditions)
                    query += condition + " AND ";
                query = query.Substring(0, query.Length - " AND ".Length); // Saca el ultimo AND
            }

            return query;
        }

        private bool seIngresaronDatos() {
            return tbUsername.Text.ToString().Length != 0;
        }

        public void setLvProperties() {
            this.lvUsuarios.Columns.Add("Username");
            this.lvUsuarios.Columns.Add("Apellido");
            this.lvUsuarios.Columns.Add("Nombre");
            this.lvUsuarios.Columns.Add("Mail");
            this.lvUsuarios.Columns.Add("Habilitado");
            this.lvUsuarios.View = View.Details;
            this.lvUsuarios.MultiSelect = false;
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader) {
            ListViewItem listItems = new ListViewItem(dataReader["usua_username"].ToString());
            listItems.SubItems.Add(dataReader["usua_apellido"].ToString());
            listItems.SubItems.Add(dataReader["usua_nombre"].ToString());
            listItems.SubItems.Add(dataReader["usua_mail"].ToString());
            listItems.SubItems.Add(dataReader["usua_habilitado"].ToString());
            return listItems;
        }

    }
}
