using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible {
    public partial class frmRegistrarConsumible : Form {
        
        public frmRegistrarConsumible() { InitializeComponent(); }

        private void btnRegistrarConsumible_Click(object sender, EventArgs e) {

            

            if (!nombreVacio()) {
                int codigo = Convert.ToInt16(this.tbCodigoConsumible.Text.ToString());
                string descripcion = this.tbDescripcionConsumible.Text.ToString();
                double precio = Convert.ToDouble(this.nudPrecioConsumible.Value);

                ListViewItem item = new ListViewItem();
                item = lvConsumibles.Items.Add(codigo.ToString());
                item.SubItems.Add(precio.ToString());
                item.SubItems.Add(descripcion);

                this.limpiarCampos();

                Consumible nuevoConsumible = new Consumible(codigo, precio,descripcion);
                nuevoConsumible.registrar();
                if( !nuevoConsumible.seRegistroCorrectamente() )
                    this.msgDatosIncorrectos();
            }
            else
                this.msgDatosIncorrectos();
        }

        private void limpiarCampos()
        {
            tbCodigoConsumible.Clear();
            tbDescripcionConsumible.Clear();
            nudPrecioConsumible.ResetText();
        }

        private bool nombreVacio() {
            return this.tbCodigoConsumible.Text.ToString().Length == 0;
        }

        private void msgDatosIncorrectos() {
            MessageBox.Show("Los datos ingresados ya existen o no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoverConsumible_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lvConsumibles.SelectedItems)
            {
                lista.Remove();
            }
        }

    }
}
