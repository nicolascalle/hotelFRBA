﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel {
    public partial class Inicio : Form {

        public Inicio() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e) {
            Login.frmLogin i = new Login.frmLogin();
            i.Show();
            i.Closed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
