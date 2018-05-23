namespace FrbaHotel.AbmCliente
{
    partial class frmABMCliente
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
            this.btnListado = new System.Windows.Forms.Button();
            this.frmAlta = new System.Windows.Forms.Button();
            this.frmBaja = new System.Windows.Forms.Button();
            this.frmModificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(71, 86);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(75, 23);
            this.btnListado.TabIndex = 0;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // frmAlta
            // 
            this.frmAlta.Location = new System.Drawing.Point(185, 86);
            this.frmAlta.Name = "frmAlta";
            this.frmAlta.Size = new System.Drawing.Size(75, 23);
            this.frmAlta.TabIndex = 1;
            this.frmAlta.Text = "Alta";
            this.frmAlta.UseVisualStyleBackColor = true;
            this.frmAlta.Click += new System.EventHandler(this.frmAlta_Click);
            // 
            // frmBaja
            // 
            this.frmBaja.Location = new System.Drawing.Point(71, 125);
            this.frmBaja.Name = "frmBaja";
            this.frmBaja.Size = new System.Drawing.Size(75, 23);
            this.frmBaja.TabIndex = 2;
            this.frmBaja.Text = "Baja";
            this.frmBaja.UseVisualStyleBackColor = true;
            this.frmBaja.Click += new System.EventHandler(this.frmBaja_Click);
            // 
            // frmModificacion
            // 
            this.frmModificacion.Location = new System.Drawing.Point(185, 125);
            this.frmModificacion.Name = "frmModificacion";
            this.frmModificacion.Size = new System.Drawing.Size(75, 23);
            this.frmModificacion.TabIndex = 3;
            this.frmModificacion.Text = "Modificacion";
            this.frmModificacion.UseVisualStyleBackColor = true;
            this.frmModificacion.Click += new System.EventHandler(this.frmModificacion_Click);
            // 
            // frmABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 296);
            this.Controls.Add(this.frmModificacion);
            this.Controls.Add(this.frmBaja);
            this.Controls.Add(this.frmAlta);
            this.Controls.Add(this.btnListado);
            this.Name = "frmABMCliente";
            this.Text = "ABM Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button frmAlta;
        private System.Windows.Forms.Button frmBaja;
        private System.Windows.Forms.Button frmModificacion;
    }
}