namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmModificarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombreHotel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaFinalReserva = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoRegimen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoHab = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumeroDeReserva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Nombre del Hotel:";
            // 
            // tbNombreHotel
            // 
            this.tbNombreHotel.Location = new System.Drawing.Point(230, 56);
            this.tbNombreHotel.Name = "tbNombreHotel";
            this.tbNombreHotel.Size = new System.Drawing.Size(100, 20);
            this.tbNombreHotel.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Fecha hasta:";
            // 
            // dtFechaFinalReserva
            // 
            this.dtFechaFinalReserva.Location = new System.Drawing.Point(155, 119);
            this.dtFechaFinalReserva.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFinalReserva.Name = "dtFechaFinalReserva";
            this.dtFechaFinalReserva.Size = new System.Drawing.Size(192, 20);
            this.dtFechaFinalReserva.TabIndex = 78;
            // 
            // dtFechaInicioReserva
            // 
            this.dtFechaInicioReserva.Location = new System.Drawing.Point(155, 91);
            this.dtFechaInicioReserva.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaInicioReserva.Name = "dtFechaInicioReserva";
            this.dtFechaInicioReserva.Size = new System.Drawing.Size(192, 20);
            this.dtFechaInicioReserva.TabIndex = 77;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 27);
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Fecha desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tipo de Regimen:";
            // 
            // cbTipoRegimen
            // 
            this.cbTipoRegimen.FormattingEnabled = true;
            this.cbTipoRegimen.Items.AddRange(new object[] {
            "All Inclusive",
            "All Inclusive moderado",
            "Media Pensión",
            "Pension Completa"});
            this.cbTipoRegimen.Location = new System.Drawing.Point(226, 175);
            this.cbTipoRegimen.Name = "cbTipoRegimen";
            this.cbTipoRegimen.Size = new System.Drawing.Size(121, 21);
            this.cbTipoRegimen.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tipo de Habitación:";
            // 
            // cbTipoHab
            // 
            this.cbTipoHab.FormattingEnabled = true;
            this.cbTipoHab.Items.AddRange(new object[] {
            "Base Simple",
            "Base Doble",
            "King",
            "Base Triple",
            "Base Cuádruple"});
            this.cbTipoHab.Location = new System.Drawing.Point(226, 148);
            this.cbTipoHab.Name = "cbTipoHab";
            this.cbTipoHab.Size = new System.Drawing.Size(121, 21);
            this.cbTipoHab.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Número de reserva a modificar:";
            // 
            // tbNumeroDeReserva
            // 
            this.tbNumeroDeReserva.Location = new System.Drawing.Point(230, 27);
            this.tbNumeroDeReserva.Name = "tbNumeroDeReserva";
            this.tbNumeroDeReserva.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroDeReserva.TabIndex = 84;
            // 
            // frmModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 254);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumeroDeReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNombreHotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaFinalReserva);
            this.Controls.Add(this.dtFechaInicioReserva);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoRegimen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoHab);
            this.Name = "frmModificarReserva";
            this.Text = "frmModificarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombreHotel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaFinalReserva;
        private System.Windows.Forms.DateTimePicker dtFechaInicioReserva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoRegimen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoHab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumeroDeReserva;

    }
}