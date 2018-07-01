﻿using System;
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
    public partial class frmSeleccionarSiSeAlojoAlgunaVez : Form
    {
        public frmSeleccionarSiSeAlojoAlgunaVez()
        {
            InitializeComponent();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            frmBuscarCliente ventanaBuscarCliente = new frmBuscarCliente();
            ventanaBuscarCliente.ShowDialog();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente ventanaRegistrarCliente = new frmRegistrarCliente();
            ventanaRegistrarCliente.ShowDialog();
            this.Close();
        }
    }
}
