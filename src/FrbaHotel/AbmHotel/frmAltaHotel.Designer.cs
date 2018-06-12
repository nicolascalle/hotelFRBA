namespace FrbaHotel.AbmHotel {
    partial class frmAltaHotel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.NuevoHotel = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombreHotel = new System.Windows.Forms.TextBox();
            this.tbMailHotel = new System.Windows.Forms.TextBox();
            this.cbCantidadEstrellasHotel = new System.Windows.Forms.ComboBox();
            this.tbTelefonoHotel = new System.Windows.Forms.TextBox();
            this.tbCalleHotel = new System.Windows.Forms.TextBox();
            this.tbNroCalleHotel = new System.Windows.Forms.TextBox();
            this.tbCiudadHotel = new System.Windows.Forms.TextBox();
            this.tbPaisHotel = new System.Windows.Forms.TextBox();
            this.nudRecargaEstrellasHotel = new System.Windows.Forms.NumericUpDown();
            this.dtFechaCreacionHotel = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecargaEstrellasHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoHotel
            // 
            this.NuevoHotel.AutoSize = true;
            this.NuevoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoHotel.Location = new System.Drawing.Point(10, 10);
            this.NuevoHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NuevoHotel.Name = "NuevoHotel";
            this.NuevoHotel.Size = new System.Drawing.Size(96, 20);
            this.NuevoHotel.TabIndex = 0;
            this.NuevoHotel.Text = "Nuevo Hotel";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(273, 254);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(62, 26);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de creación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estrellas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "País:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Recarga Estrellas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nro:";
            // 
            // tbNombreHotel
            // 
            this.tbNombreHotel.Location = new System.Drawing.Point(116, 41);
            this.tbNombreHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombreHotel.Name = "tbNombreHotel";
            this.tbNombreHotel.Size = new System.Drawing.Size(92, 20);
            this.tbNombreHotel.TabIndex = 12;
            // 
            // tbMailHotel
            // 
            this.tbMailHotel.Location = new System.Drawing.Point(116, 62);
            this.tbMailHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMailHotel.Name = "tbMailHotel";
            this.tbMailHotel.Size = new System.Drawing.Size(92, 20);
            this.tbMailHotel.TabIndex = 13;
            // 
            // cbCantidadEstrellasHotel
            // 
            this.cbCantidadEstrellasHotel.FormattingEnabled = true;
            this.cbCantidadEstrellasHotel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCantidadEstrellasHotel.Location = new System.Drawing.Point(116, 125);
            this.cbCantidadEstrellasHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCantidadEstrellasHotel.Name = "cbCantidadEstrellasHotel";
            this.cbCantidadEstrellasHotel.Size = new System.Drawing.Size(38, 21);
            this.cbCantidadEstrellasHotel.TabIndex = 14;
            // 
            // tbTelefonoHotel
            // 
            this.tbTelefonoHotel.Location = new System.Drawing.Point(116, 83);
            this.tbTelefonoHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTelefonoHotel.Name = "tbTelefonoHotel";
            this.tbTelefonoHotel.Size = new System.Drawing.Size(92, 20);
            this.tbTelefonoHotel.TabIndex = 15;
            // 
            // tbCalleHotel
            // 
            this.tbCalleHotel.Location = new System.Drawing.Point(116, 104);
            this.tbCalleHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCalleHotel.Name = "tbCalleHotel";
            this.tbCalleHotel.Size = new System.Drawing.Size(92, 20);
            this.tbCalleHotel.TabIndex = 16;
            // 
            // tbNroCalleHotel
            // 
            this.tbNroCalleHotel.Location = new System.Drawing.Point(256, 104);
            this.tbNroCalleHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNroCalleHotel.Name = "tbNroCalleHotel";
            this.tbNroCalleHotel.Size = new System.Drawing.Size(76, 20);
            this.tbNroCalleHotel.TabIndex = 17;
            // 
            // tbCiudadHotel
            // 
            this.tbCiudadHotel.Location = new System.Drawing.Point(116, 146);
            this.tbCiudadHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCiudadHotel.Name = "tbCiudadHotel";
            this.tbCiudadHotel.Size = new System.Drawing.Size(91, 20);
            this.tbCiudadHotel.TabIndex = 18;
            // 
            // tbPaisHotel
            // 
            this.tbPaisHotel.Location = new System.Drawing.Point(116, 167);
            this.tbPaisHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPaisHotel.Name = "tbPaisHotel";
            this.tbPaisHotel.Size = new System.Drawing.Size(91, 20);
            this.tbPaisHotel.TabIndex = 19;
            // 
            // nudRecargaEstrellasHotel
            // 
            this.nudRecargaEstrellasHotel.DecimalPlaces = 2;
            this.nudRecargaEstrellasHotel.Location = new System.Drawing.Point(116, 211);
            this.nudRecargaEstrellasHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudRecargaEstrellasHotel.Name = "nudRecargaEstrellasHotel";
            this.nudRecargaEstrellasHotel.Size = new System.Drawing.Size(90, 20);
            this.nudRecargaEstrellasHotel.TabIndex = 21;
            // 
            // dtFechaCreacionHotel
            // 
            this.dtFechaCreacionHotel.Location = new System.Drawing.Point(116, 190);
            this.dtFechaCreacionHotel.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaCreacionHotel.Name = "dtFechaCreacionHotel";
            this.dtFechaCreacionHotel.Size = new System.Drawing.Size(192, 20);
            this.dtFechaCreacionHotel.TabIndex = 20;
            // 
            // frmAltaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 290);
            this.Controls.Add(this.nudRecargaEstrellasHotel);
            this.Controls.Add(this.dtFechaCreacionHotel);
            this.Controls.Add(this.tbPaisHotel);
            this.Controls.Add(this.tbCiudadHotel);
            this.Controls.Add(this.tbNroCalleHotel);
            this.Controls.Add(this.tbCalleHotel);
            this.Controls.Add(this.tbTelefonoHotel);
            this.Controls.Add(this.cbCantidadEstrellasHotel);
            this.Controls.Add(this.tbMailHotel);
            this.Controls.Add(this.tbNombreHotel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.NuevoHotel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAltaHotel";
            this.Text = "frmAltaHotel";
            ((System.ComponentModel.ISupportInitialize)(this.nudRecargaEstrellasHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NuevoHotel;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombreHotel;
        private System.Windows.Forms.TextBox tbMailHotel;
        private System.Windows.Forms.ComboBox cbCantidadEstrellasHotel;
        private System.Windows.Forms.TextBox tbTelefonoHotel;
        private System.Windows.Forms.TextBox tbCalleHotel;
        private System.Windows.Forms.TextBox tbNroCalleHotel;
        private System.Windows.Forms.TextBox tbCiudadHotel;
        private System.Windows.Forms.TextBox tbPaisHotel;
        private System.Windows.Forms.NumericUpDown nudRecargaEstrellasHotel;
        private System.Windows.Forms.DateTimePicker dtFechaCreacionHotel;
    }
}