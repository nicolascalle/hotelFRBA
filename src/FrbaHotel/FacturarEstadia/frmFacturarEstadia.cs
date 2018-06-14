using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.FacturarEstadia {
    public partial class frmFacturarEstadia : Form {

        List<Item> items = new List<Item>();

        public frmFacturarEstadia() { InitializeComponent(); }

        public void setItems(List<Item> items) { this.items = items; }

        private void btnFacturarEstadia_Click(object sender, EventArgs e) {
            if( this.camposObligatoriosCompletos() ) {
                string nroReserva = tbNroReserva.Text.ToString();
                Factura factura = new Factura(nroReserva, cbFormaDePago.SelectedItem.ToString());
                //if (factura.reservaExists()) { 
                    items.ForEach(item => factura.agregarItem(item));
                    frmConfirmarFactura frmA = new frmConfirmarFactura();
                    frmA.setFactura(factura);
                    frmA.Show();
                //}
                //else 
                //  this.codigoReservaIncorrecto();
            }
        }

        private bool camposObligatoriosCompletos() { 
            return new List<Control> { tbNroReserva, cbFormaDePago }.All(form => form.Text.Length != 0);
        }

        private void btnRegistrarConsumibles_Click(object sender, EventArgs e) {
            RegistrarConsumible.frmRegistrarConsumible i = new RegistrarConsumible.frmRegistrarConsumible();
            i.Show();
            this.Close();
        }

        private void msgCodigoReservaIncorrecto() {
            MessageBox.Show("No se encontro una reserva con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
