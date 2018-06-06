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
            this.dtFechaCreacionHotel = new System.Windows.Forms.DateTimePicker();
            this.nudRecargaEstrellasHotel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecargaEstrellasHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoHotel
            // 
            this.NuevoHotel.AutoSize = true;
            this.NuevoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoHotel.Location = new System.Drawing.Point(14, 12);
            this.NuevoHotel.Name = "NuevoHotel";
            this.NuevoHotel.Size = new System.Drawing.Size(119, 25);
            this.NuevoHotel.TabIndex = 0;
            this.NuevoHotel.Text = "Nuevo Hotel";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(364, 313);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de creación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Estrellas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "País:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Recarga Estrellas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nro:";
            // 
            // tbNombreHotel
            // 
            this.tbNombreHotel.Location = new System.Drawing.Point(154, 50);
            this.tbNombreHotel.Name = "tbNombreHotel";
            this.tbNombreHotel.Size = new System.Drawing.Size(121, 22);
            this.tbNombreHotel.TabIndex = 12;
            // 
            // tbMailHotel
            // 
            this.tbMailHotel.Location = new System.Drawing.Point(154, 76);
            this.tbMailHotel.Name = "tbMailHotel";
            this.tbMailHotel.Size = new System.Drawing.Size(121, 22);
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
            this.cbCantidadEstrellasHotel.Location = new System.Drawing.Point(154, 154);
            this.cbCantidadEstrellasHotel.Name = "cbCantidadEstrellasHotel";
            this.cbCantidadEstrellasHotel.Size = new System.Drawing.Size(50, 24);
            this.cbCantidadEstrellasHotel.TabIndex = 14;
            // 
            // tbTelefonoHotel
            // 
            this.tbTelefonoHotel.Location = new System.Drawing.Point(154, 102);
            this.tbTelefonoHotel.Name = "tbTelefonoHotel";
            this.tbTelefonoHotel.Size = new System.Drawing.Size(121, 22);
            this.tbTelefonoHotel.TabIndex = 15;
            // 
            // tbCalleHotel
            // 
            this.tbCalleHotel.Location = new System.Drawing.Point(154, 128);
            this.tbCalleHotel.Name = "tbCalleHotel";
            this.tbCalleHotel.Size = new System.Drawing.Size(121, 22);
            this.tbCalleHotel.TabIndex = 16;
            // 
            // tbNroCalleHotel
            // 
            this.tbNroCalleHotel.Location = new System.Drawing.Point(342, 128);
            this.tbNroCalleHotel.Name = "tbNroCalleHotel";
            this.tbNroCalleHotel.Size = new System.Drawing.Size(100, 22);
            this.tbNroCalleHotel.TabIndex = 17;
            // 
            // tbCiudadHotel
            // 
            this.tbCiudadHotel.Location = new System.Drawing.Point(154, 180);
            this.tbCiudadHotel.Name = "tbCiudadHotel";
            this.tbCiudadHotel.Size = new System.Drawing.Size(120, 22);
            this.tbCiudadHotel.TabIndex = 18;
            // 
            // tbPaisHotel
            // 
            this.tbPaisHotel.Location = new System.Drawing.Point(154, 206);
            this.tbPaisHotel.Name = "tbPaisHotel";
            this.tbPaisHotel.Size = new System.Drawing.Size(120, 22);
            this.tbPaisHotel.TabIndex = 19;
            // 
            // dtFechaCreacionHotel
            // 
            this.dtFechaCreacionHotel.Location = new System.Drawing.Point(154, 234);
            this.dtFechaCreacionHotel.Name = "dtFechaCreacionHotel";
            this.dtFechaCreacionHotel.Size = new System.Drawing.Size(255, 22);
            this.dtFechaCreacionHotel.TabIndex = 20;
            // 
            // nudRecargaEstrellasHotel
            // 
            this.nudRecargaEstrellasHotel.DecimalPlaces = 2;
            this.nudRecargaEstrellasHotel.Location = new System.Drawing.Point(154, 260);
            this.nudRecargaEstrellasHotel.Name = "nudRecargaEstrellasHotel";
            this.nudRecargaEstrellasHotel.Size = new System.Drawing.Size(120, 22);
            this.nudRecargaEstrellasHotel.TabIndex = 21;
            // 
            // frmAltaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 357);
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
        private System.Windows.Forms.DateTimePicker dtFechaCreacionHotel;
        private System.Windows.Forms.NumericUpDown nudRecargaEstrellasHotel;
    }
}