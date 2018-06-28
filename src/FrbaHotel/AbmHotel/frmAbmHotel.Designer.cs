namespace FrbaHotel.AbmHotel
{
    partial class frmAbmHotel
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
            this.frmModificacion = new System.Windows.Forms.Button();
            this.frmBaja = new System.Windows.Forms.Button();
            this.frmAlta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lvHoteles = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCantidadEstrellas = new System.Windows.Forms.ComboBox();
            this.tbNombreHotel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmModificacion
            // 
            this.frmModificacion.Location = new System.Drawing.Point(661, 217);
            this.frmModificacion.Margin = new System.Windows.Forms.Padding(4);
            this.frmModificacion.Name = "frmModificacion";
            this.frmModificacion.Size = new System.Drawing.Size(100, 28);
            this.frmModificacion.TabIndex = 7;
            this.frmModificacion.Text = "Modificacion";
            this.frmModificacion.UseVisualStyleBackColor = true;
            this.frmModificacion.Click += new System.EventHandler(this.frmModificacion_Click);
            // 
            // frmBaja
            // 
            this.frmBaja.Location = new System.Drawing.Point(661, 171);
            this.frmBaja.Margin = new System.Windows.Forms.Padding(4);
            this.frmBaja.Name = "frmBaja";
            this.frmBaja.Size = new System.Drawing.Size(100, 28);
            this.frmBaja.TabIndex = 6;
            this.frmBaja.Text = "Baja";
            this.frmBaja.UseVisualStyleBackColor = true;
            this.frmBaja.Click += new System.EventHandler(this.frmBaja_Click);
            // 
            // frmAlta
            // 
            this.frmAlta.Location = new System.Drawing.Point(661, 125);
            this.frmAlta.Margin = new System.Windows.Forms.Padding(4);
            this.frmAlta.Name = "frmAlta";
            this.frmAlta.Size = new System.Drawing.Size(100, 28);
            this.frmAlta.TabIndex = 5;
            this.frmAlta.Text = "Alta";
            this.frmAlta.UseVisualStyleBackColor = true;
            this.frmAlta.Click += new System.EventHandler(this.frmAlta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(546, 397);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lvHoteles
            // 
            this.lvHoteles.FullRowSelect = true;
            this.lvHoteles.GridLines = true;
            this.lvHoteles.Location = new System.Drawing.Point(29, 66);
            this.lvHoteles.MultiSelect = false;
            this.lvHoteles.Name = "lvHoteles";
            this.lvHoteles.Size = new System.Drawing.Size(617, 256);
            this.lvHoteles.TabIndex = 8;
            this.lvHoteles.UseCompatibleStateImageBehavior = false;
            this.lvHoteles.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ABM Hotel";
            // 
            // cbCantidadEstrellas
            // 
            this.cbCantidadEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCantidadEstrellas.FormattingEnabled = true;
            this.cbCantidadEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCantidadEstrellas.Location = new System.Drawing.Point(205, 400);
            this.cbCantidadEstrellas.Name = "cbCantidadEstrellas";
            this.cbCantidadEstrellas.Size = new System.Drawing.Size(50, 24);
            this.cbCantidadEstrellas.TabIndex = 10;
            // 
            // tbNombreHotel
            // 
            this.tbNombreHotel.Location = new System.Drawing.Point(119, 348);
            this.tbNombreHotel.Name = "tbNombreHotel";
            this.tbNombreHotel.Size = new System.Drawing.Size(136, 22);
            this.tbNombreHotel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cantidad de estrellas:";
            // 
            // frmAbmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreHotel);
            this.Controls.Add(this.cbCantidadEstrellas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvHoteles);
            this.Controls.Add(this.frmModificacion);
            this.Controls.Add(this.frmBaja);
            this.Controls.Add(this.frmAlta);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAbmHotel";
            this.Text = "ABM Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmModificacion;
        private System.Windows.Forms.Button frmBaja;
        private System.Windows.Forms.Button frmAlta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvHoteles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCantidadEstrellas;
        private System.Windows.Forms.TextBox tbNombreHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}