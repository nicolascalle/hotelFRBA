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

        public frmAltaHotel() { InitializeComponent(); }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.camposObligatoriosCompletos()) {
                Hotel nuevoHotel = new Hotel();
                nuevoHotel.setNombre(tbNombreHotel.Text.ToString());
                nuevoHotel.setMail(tbMailHotel.Text.ToString());
                nuevoHotel.setTelefono(tbTelefonoHotel.Text.ToString());
                nuevoHotel.setDire_calle(tbCalleHotel.Text.ToString());
                nuevoHotel.setDire_nro(tbNroCalleHotel.Text.ToString());
                nuevoHotel.setEstrellas(Convert.ToInt16(cbCantidadEstrellasHotel.Text.ToString()));
                nuevoHotel.setCiudad(tbCiudadHotel.Text.ToString());
                nuevoHotel.setPais(tbPaisHotel.Text.ToString());
                nuevoHotel.setFechaCreacion(dtFechaCreacionHotel.Value);
                nuevoHotel.setRecargaEstrellas(Convert.ToDouble(nudRecargaEstrellasHotel.Value));
                nuevoHotel.guardar();
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
