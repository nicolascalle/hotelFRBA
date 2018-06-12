using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmGenerarReserva : Form
    {
        public frmGenerarReserva()
        {
            InitializeComponent();
            dtFechaInicioReserva.MinDate = dtFechaInicioReserva.Value;
        }

        private void frmGenerarReserva_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.camposSinSeleccionar())
            {
                Reserva nuevaReserva = new Reserva(dtFechaInicioReserva.Value, dtFechaFinalReserva.Value, cbTipoHab.Text.ToString(), cbTipoRegimen.Text.ToString()); //Convert.ToInt32(cbTipoHab.Text.ToString()), 
                nuevaReserva.guardar();
            }
            Close();
        }

        private bool camposSinSeleccionar()
        {
            return cbTipoHab.Text.Length != 0 && cbTipoRegimen.Text.Length != 0 ;
        }

    }

}
