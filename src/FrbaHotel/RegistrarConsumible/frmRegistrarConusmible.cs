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
                String nombre = this.tbNombreConsumible.Text.ToString();
                double precio = Convert.ToDouble(this.nudPrecioConsumible.Value);
                Consumible nuevoConsumible = new Consumible(nombre, precio);
                nuevoConsumible.registrar();
                if( !nuevoConsumible.seRegistroCorrectamente() )
                    this.msgDatosIncorrectos();
            }
            else
                this.msgDatosIncorrectos();
        }

        private bool nombreVacio() {
            return this.tbNombreConsumible.Text.ToString().Length == 0;
        }

        private void msgDatosIncorrectos() {
            MessageBox.Show("Los datos ingresados ya existen o no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
