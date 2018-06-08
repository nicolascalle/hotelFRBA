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
    public partial class frmModificacionRol : Form {

        private Rol rol;

        public frmModificacionRol() {
            InitializeComponent();
            this.setLvProperties();
            this.cargarFuncionalidadesDisponibles();
        }

        public void setRol(Rol rol) {
            this.rol = rol;
            this.cargarRolActual();
        }

        public void cargarRolActual() { 
            tbNombreRol.Text = rol.getNombre();
            rol.getFuncionalidades().ForEach(funcionalidad => lvFuncionalidades.Items.Add(new ListViewItem(funcionalidad)));
            cbHabilitado.Checked = rol.getHabilitado();
        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e) {
            string funcionalidadAgregar = cbFuncionalidades.SelectedItem.ToString();
            if (funcionalidadAgregar.Length != 0)
                lvFuncionalidades.Items.Add(funcionalidadAgregar);
        }

        private void btnQuitarFuncionalidad_Click(object sender, EventArgs e) {
            if (lvFuncionalidades.SelectedItems.Count == 1)
                lvFuncionalidades.SelectedItems[0].Remove();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                string nombreRol = tbNombreRol.Text.ToString();
                Rol nuevoRol = new Rol(nombreRol);
                nuevoRol.setHabilitado( cbHabilitado.Checked );
                for (int i = 0; i < lvFuncionalidades.Items.Count; i++)
                    nuevoRol.agregarFuncionalidad(lvFuncionalidades.Items[i].Text.ToString());
                nuevoRol.guardar();
            }
            Close();
        }

        private bool camposObligatoriosCompletos() {
            return tbNombreRol.Text.Length != 0 && lvFuncionalidades.Items.Count != 0;
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
