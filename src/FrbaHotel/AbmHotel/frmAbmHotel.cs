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

        public frmAbmHotel() { InitializeComponent(); }

        private void btnBuscar_Click(object sender, EventArgs e) {

            this.lvHoteles.Items.Clear();
            string query = this.generateQuery();
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            while (dataReader.Read()) {

                ListViewItem listItems = new ListViewItem(dataReader["hote_nombre"].ToString());
                listItems.SubItems.Add(dataReader["hote_cant_estrellas"].ToString());
                listItems.SubItems.Add(dataReader["hote_ciudad"].ToString());
                listItems.SubItems.Add(dataReader["hote_pais"].ToString());
                this.lvHoteles.Items.Add(listItems);
            }
            dataReader.Close();
        }

        private void frmBaja_Click(object sender, EventArgs e) {

        }

        private void frmModificacion_Click(object sender, EventArgs e) {

        }

        private string generateQuery() {

            string query = "SELECT hote_nombre, hote_cant_estrellas, hote_ciudad, hote_pais FROM FAAE.Hotel";
            string nombrehotel = tbNombreHotel.Text.ToString();
            string estrellas = cbCantidadEstrellas.Text.ToString();
            
            if ( this.seIngresaronDatos() ) {
                Dictionary<string, string> args = new Dictionary<string, string>();

                if ( nombrehotel.Length != 0 )
                    args.Add("hote_nombre", " LIKE '%"+ nombrehotel +"%'"); // Para strings

                if ( estrellas.Length != 0 )
                    args.Add("hote_cant_estrellas", "=" + estrellas); // Para numeros

                query += " WHERE ";
                foreach ( var item in args )
                    query += item.Key + item.Value + " AND ";
                query = query.Substring(0, query.Length - " AND ".Length); // Saca el ultimo AND
            }
            
            return query;
        }

        private bool seIngresaronDatos() {
            return tbNombreHotel.Text.ToString().Length != 0 || cbCantidadEstrellas.Text.ToString().Length != 0;
        }

    }
}
