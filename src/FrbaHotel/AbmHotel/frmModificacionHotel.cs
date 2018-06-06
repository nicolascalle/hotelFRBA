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
    public partial class frmModificacionHotel : Form {

        private Hotel hotel;

        public frmModificacionHotel() { InitializeComponent(); }

        public void setHotel(Hotel hotel) {
            this.hotel = hotel;
            this.cargarHotelActual();        
        }

        private void cargarHotelActual() {
            tbNombreHotel.Text = hotel.getNombre();
            tbMailHotel.Text = hotel.getMail();
            tbTelefonoHotel.Text = hotel.getTelefono();
            tbCalleHotel.Text = hotel.getDire_calle();
            tbNroCalleHotel.Text = hotel.getDire_nro();
            cbCantidadEstrellasHotel.Text = hotel.getEstrellas().ToString();
            tbCiudadHotel.Text = hotel.getCiudad();
            tbPaisHotel.Text = hotel.getPais();
            dtFechaCreacionHotel.Text = hotel.getFechaCreacion().ToShortDateString();
            nudRecargaEstrellasHotel.Text = hotel.getRecargaEstrellas().ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                hotel.setNombre(tbNombreHotel.Text.ToString());
                hotel.setMail(tbMailHotel.Text.ToString());
                hotel.setTelefono(tbTelefonoHotel.Text.ToString());
                hotel.setDire_calle(tbCalleHotel.Text.ToString());
                hotel.setDire_nro(tbNroCalleHotel.Text.ToString());
                hotel.setEstrellas(Convert.ToInt16(cbCantidadEstrellasHotel.Text.ToString()));
                hotel.setCiudad(tbCiudadHotel.Text.ToString());
                hotel.setPais(tbPaisHotel.Text.ToString());
                hotel.setFechaCreacion(dtFechaCreacionHotel.Value);
                hotel.setRecargaEstrellas(Convert.ToDouble(nudRecargaEstrellasHotel.Value));
                hotel.guardar();
            }
            Close();
        }

        private bool camposObligatoriosCompletos() {
            return tbNombreHotel.Text.Length   != 0 && 
                   tbCalleHotel.Text.Length    != 0 && 
                   tbNroCalleHotel.Text.Length != 0 && 
                   cbCantidadEstrellasHotel.Text.Length != 0;
        }


    }
}
