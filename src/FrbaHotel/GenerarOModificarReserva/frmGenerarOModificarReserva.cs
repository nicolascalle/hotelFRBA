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
    public partial class frmGenerarOModificarReserva : Form
    {
        public frmGenerarOModificarReserva()
        {
            InitializeComponent();
        }

        private void btnGenerarReserva_Click(object sender, EventArgs e)
        {
            frmGenerarReserva ventanaGenerarReserva = new frmGenerarReserva();
            ventanaGenerarReserva.Show();
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            frmSeleccionarReserva ventanaSeleccionar = new frmSeleccionarReserva();
            ventanaSeleccionar.Show();
        }
    }
}
