using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol {
    public partial class frmAltaRol : Form {
        public frmAltaRol() {
            InitializeComponent();
            this.setLvProperties();
            this.cargarFuncionalidadesDisponibles();
        }

        public void cargarFuncionalidadesDisponibles() {
            this.lvFuncionalidades.Items.Clear();
            string query = "SELECT DISTINCT func_funcion FROM FAAE.Funcionalidad";
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);

            while (dataReader.Read()) {
                ListViewItem listItem = this.nuevoItem(dataReader);
                this.cbFuncionalidades.Items.Add(listItem.Text.ToString());
            }
            dataReader.Close();
        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e) {
            string funcionalidadAgregar = cbFuncionalidades.SelectedItem.ToString();
            if (funcionalidadAgregar.Length != 0)
                lvFuncionalidades.Items.Add(funcionalidadAgregar);
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                string nombreRol = tbNombreRol.Text.ToString();
                Rol nuevoRol = new Rol(nombreRol);
                for (int i = 0; i < lvFuncionalidades.Items.Count; i++)
                    nuevoRol.agregarFuncionalidad(lvFuncionalidades.Items[i].Text.ToString());
                nuevoRol.guardar();
            }
            Close();
        }

        private bool camposObligatoriosCompletos() {
            return tbNombreRol.Text.Length != 0 && lvFuncionalidades.Items.Count != 0;
        }

        public void setLvProperties() {
            this.lvFuncionalidades.Columns.Add("Funcionalidad");
            this.lvFuncionalidades.View = View.Details;
            this.lvFuncionalidades.MultiSelect = false;
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader) {
            ListViewItem listItems = new ListViewItem(dataReader["func_funcion"].ToString());
            return listItems;
        }
    }
}
