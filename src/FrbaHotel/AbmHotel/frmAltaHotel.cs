using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel {
    public partial class frmAltaHotel : Form {

        private Hotel hotel;

        public frmAltaHotel() { InitializeComponent(); }

        public void setHotel(Hotel hotel) {
            this.hotel = hotel;
            this.cargarHotelActual();        
        }

        private void cargarHotelActual() {
            tbNombreHotel.Text            = hotel.getNombre();
            tbMailHotel.Text              = hotel.getMail();
            tbTelefonoHotel.Text          = hotel.getTelefono();
            tbCalleHotel.Text             = hotel.getDire_calle();
            tbNroCalleHotel.Text          = hotel.getDire_nro();
            cbCantidadEstrellasHotel.Text = hotel.getEstrellas().ToString();
            tbCiudadHotel.Text            = hotel.getCiudad();
            tbPaisHotel.Text              = hotel.getPais();
            dtFechaCreacionHotel.Text     = hotel.getFechaCreacion().ToShortDateString();
            nudRecargaEstrellasHotel.Text = hotel.getRecargaEstrellas().ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                Hotel hote = this.getHotel();
                hotel.setNombre(tbNombreHotel.Text.ToString());
                hotel.setMail(tbMailHotel.Text.ToString());
                hotel.setTelefono(tbTelefonoHotel.Text.ToString());
                hotel.setDire_calle(tbCalleHotel.Text.ToString());
                hotel.setDire_nro(tbNroCalleHotel.Text.ToString());
                hotel.setEstrellas(Convert.ToInt16(cbCantidadEstrellasHotel.Text.ToString()));
                hotel.setCiudad(tbCiudadHotel.Text.ToString());
                hotel.setPais(tbPaisHotel.Text.ToString());
                if (dtFechaCreacionHotel.Value != null) 
                    hotel.setFechaCreacion(dtFechaCreacionHotel.Value);
                hotel.setRecargaEstrellas(Convert.ToDecimal(nudRecargaEstrellasHotel.Value));
                hotel.guardar();
            }
            Close();
        }

        private bool camposObligatoriosCompletos() {
            return new List<Control> { tbNombreHotel, tbCalleHotel, tbNroCalleHotel, cbCantidadEstrellasHotel }.All(form => form.Text.Length != 0);
        }

        public void setTitle(string title) {
            this.ModificarHotel.Text = title;
        }

        private Hotel getHotel() {
            if (hotel == null)
                return new Hotel();
            return this.hotel;
        }

    }
}
