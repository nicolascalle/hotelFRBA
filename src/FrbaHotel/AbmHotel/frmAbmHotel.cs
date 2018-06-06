using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.AbmHotel {
    public partial class frmAbmHotel : Form {

        public frmAbmHotel() { 
            InitializeComponent();
            this.setLvProperties();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {

            this.lvHoteles.Items.Clear();
            string query = this.generateQuery();
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader);
                this.lvHoteles.Items.Add(listItem);
            }
            dataReader.Close();
        }

        private void frmAlta_Click(object sender, EventArgs e) {
            AbmHotel.frmAltaHotel frmA = new AbmHotel.frmAltaHotel();
            frmA.Show();
        }

        private void frmBaja_Click(object sender, EventArgs e) {
            if (this.lvHoteles.SelectedItems.Count == 1) {
                int codigoHotel = Convert.ToInt32(this.lvHoteles.SelectedItems[0].Text.ToString());
                new Hotel(codigoHotel).eliminar();
            }
        }

        private void frmModificacion_Click(object sender, EventArgs e) {
            if (this.lvHoteles.SelectedItems.Count == 1) {
                int codigoHotel = Convert.ToInt32(this.lvHoteles.SelectedItems[0].Text.ToString());
                Hotel hotelModificar = new Hotel(codigoHotel);
                hotelModificar.buscar();
                AbmHotel.frmModificacionHotel frmM = new AbmHotel.frmModificacionHotel();
                frmM.setHotel(hotelModificar);
                frmM.Show();
            }
        }

        private string generateQuery() {

            string query = "SELECT hote_codigo, hote_nombre, hote_cant_estrellas, hote_ciudad, hote_pais FROM FAAE.Hotel";
            string nombrehotel = tbNombreHotel.Text.ToString();
            string estrellas = cbCantidadEstrellas.Text.ToString();
            
            if ( this.seIngresaronDatos() ) {
                List<string> conditions = new List<string>();

                if ( nombrehotel.Length != 0 )
                    conditions.Add("hote_nombre LIKE '%" + nombrehotel + "%'");

                if ( estrellas.Length != 0 )
                    conditions.Add("hote_cant_estrellas = " + estrellas); 

                query += " WHERE ";
                foreach (var condition in conditions)
                    query += condition + " AND ";
                query = query.Substring(0, query.Length - " AND ".Length); // Saca el ultimo AND
            }
            
            return query;
        }

        private bool seIngresaronDatos() {
            return tbNombreHotel.Text.ToString().Length != 0 || cbCantidadEstrellas.Text.ToString().Length != 0;
        }

        public void setLvProperties() {
            this.lvHoteles.Columns.Add("Codigo");
            this.lvHoteles.Columns.Add("Nombre");
            this.lvHoteles.Columns.Add("Estrellas");
            this.lvHoteles.Columns.Add("Ciudad");
            this.lvHoteles.Columns.Add("Pais");
            this.lvHoteles.View = View.Details;
            this.lvHoteles.MultiSelect = false;
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader) {
            ListViewItem listItems = new ListViewItem(dataReader["hote_codigo"].ToString());
            listItems.SubItems.Add(dataReader["hote_nombre"].ToString());
            listItems.SubItems.Add(dataReader["hote_cant_estrellas"].ToString());
            listItems.SubItems.Add(dataReader["hote_ciudad"].ToString());
            listItems.SubItems.Add(dataReader["hote_pais"].ToString());
            return listItems;
        }

    }
}
