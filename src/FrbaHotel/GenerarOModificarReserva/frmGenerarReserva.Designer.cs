﻿namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmGenerarReserva
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoHab = new System.Windows.Forms.ComboBox();
            this.cbTipoRegimen = new System.Windows.Forms.ComboBox();
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.gD1C2018DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regimenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regimenTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.RegimenTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtFechaInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFinalReserva = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCantHabitaciones = new System.Windows.Forms.TextBox();
            this.tbNombreHotel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 45;
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
            this.cbTipoHab.Location = new System.Drawing.Point(186, 141);
            this.cbTipoHab.Name = "cbTipoHab";
            this.cbTipoHab.Size = new System.Drawing.Size(121, 21);
            this.cbTipoHab.TabIndex = 44;
            // 
            // cbTipoRegimen
            // 
            this.cbTipoRegimen.FormattingEnabled = true;
            this.cbTipoRegimen.Items.AddRange(new object[] {
            "All inclusive",
            "Media pensión"});
            this.cbTipoRegimen.Location = new System.Drawing.Point(186, 173);
            this.cbTipoRegimen.Name = "cbTipoRegimen";
            this.cbTipoRegimen.Size = new System.Drawing.Size(121, 21);
            this.cbTipoRegimen.TabIndex = 46;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD1C2018DataSetBindingSource
            // 
            this.gD1C2018DataSetBindingSource.DataSource = this.gD1C2018DataSet;
            this.gD1C2018DataSetBindingSource.Position = 0;
            // 
            // regimenBindingSource
            // 
            this.regimenBindingSource.DataMember = "Regimen";
            this.regimenBindingSource.DataSource = this.gD1C2018DataSetBindingSource;
            // 
            // regimenTableAdapter
            // 
            this.regimenTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tipo de Regimen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Fecha desde:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 27);
            this.btnGuardar.TabIndex = 50;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtFechaInicioReserva
            // 
            this.dtFechaInicioReserva.Location = new System.Drawing.Point(148, 84);
            this.dtFechaInicioReserva.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaInicioReserva.Name = "dtFechaInicioReserva";
            this.dtFechaInicioReserva.Size = new System.Drawing.Size(192, 20);
            this.dtFechaInicioReserva.TabIndex = 51;
            // 
            // dtFechaFinalReserva
            // 
            this.dtFechaFinalReserva.Location = new System.Drawing.Point(148, 112);
            this.dtFechaFinalReserva.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFinalReserva.Name = "dtFechaFinalReserva";
            this.dtFechaFinalReserva.Size = new System.Drawing.Size(192, 20);
            this.dtFechaFinalReserva.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Fecha hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Cant. de Habitaciones:";
            // 
            // tbCantHabitaciones
            // 
            this.tbCantHabitaciones.Location = new System.Drawing.Point(186, 59);
            this.tbCantHabitaciones.Name = "tbCantHabitaciones";
            this.tbCantHabitaciones.Size = new System.Drawing.Size(100, 20);
            this.tbCantHabitaciones.TabIndex = 55;
            // 
            // tbNombreHotel
            // 
            this.tbNombreHotel.Location = new System.Drawing.Point(186, 33);
            this.tbNombreHotel.Name = "tbNombreHotel";
            this.tbNombreHotel.Size = new System.Drawing.Size(100, 20);
            this.tbNombreHotel.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nombre del Hotel:";
            // 
            // frmGenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 253);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNombreHotel);
            this.Controls.Add(this.tbCantHabitaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaFinalReserva);
            this.Controls.Add(this.dtFechaInicioReserva);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoRegimen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoHab);
            this.Name = "frmGenerarReserva";
            this.Text = "frmGenerarReserva";
            this.Load += new System.EventHandler(this.frmGenerarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoHab;
        private System.Windows.Forms.ComboBox cbTipoRegimen;
        private System.Windows.Forms.BindingSource gD1C2018DataSetBindingSource;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource regimenBindingSource;
        private GD1C2018DataSetTableAdapters.RegimenTableAdapter regimenTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtFechaInicioReserva;
        private System.Windows.Forms.DateTimePicker dtFechaFinalReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCantHabitaciones;
        private System.Windows.Forms.TextBox tbNombreHotel;
        private System.Windows.Forms.Label label6;

    }
}