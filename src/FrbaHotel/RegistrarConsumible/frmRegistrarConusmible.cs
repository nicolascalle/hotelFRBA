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

namespace FrbaHotel.RegistrarConsumible {
    public partial class frmRegistrarConsumible : Form {
        
        public frmRegistrarConsumible() { 
            InitializeComponent();
            this.cargarConsumibles();
        }

        private void btnRegistrarConsumible_Click(object sender, EventArgs e) {

            if (!nombreVacio()) {
                string descripcion = cbConsumible.SelectedItem.ToString();
                string cantidad = tbCantidad.Text.ToString();
                string query = "SELECT cons_codigo, cons_precio FROM FAAE.Consumible";
                query += " WHERE cons_descipcion = '" + descripcion + "'";

                SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);
                dataReader.Read();
                ListViewItem listItem = new ListViewItem(dataReader["cons_codigo"].ToString());
                listItem.SubItems.Add(descripcion);
                listItem.SubItems.Add(cantidad);
                listItem.SubItems.Add(dataReader["cons_precio"].ToString());
                this.lvConsumibles.Items.Add(listItem);
                dataReader.Close();
            }
            else
                this.msgDatosIncorrectos();
        }

        private bool nombreVacio() {
            return this.cbConsumible.Text.Length == 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {
            List<Item> items = new List<Item>();
            for (int i = 0; i < lvConsumibles.Items.Count; i++)
                items.Add(this.getItem(i));
            FacturarEstadia.frmFacturarEstadia frm = new FacturarEstadia.frmFacturarEstadia();
            frm.setItems(items);
            frm.Show();
            this.Close();
        }

        private void btnRemoverConsumible_Click(object sender, EventArgs e) {
            foreach (ListViewItem lista in lvConsumibles.SelectedItems)
                lista.Remove();
        }

        private Item getItem(int index) {
            string cod = lvConsumibles.Items[index].Text.ToString();
            string desc = lvConsumibles.Items[index].SubItems[1].Text.ToString();
            int cant = Convert.ToInt32(lvConsumibles.Items[index].SubItems[2].Text);
            decimal prec = Convert.ToDecimal(lvConsumibles.Items[index].SubItems[3].Text);
            return new Item(cod, desc, cant, prec);
        }

        private void cargarConsumibles() {
            string query = "SELECT cons_descipcion FROM FAAE.Consumible";
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);
            while (dataReader.Read())
                cbConsumible.Items.Add(dataReader["cons_descipcion"]);
            dataReader.Close();
        }

        private void msgDatosIncorrectos() {
            MessageBox.Show("Los datos ingresados no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
