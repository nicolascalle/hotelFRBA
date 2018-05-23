namespace FrbaHotel.FuncionalidadesCliente
{
    partial class frmFuncionalidadesCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnGenerarModificacionReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reservas:";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(239, 102);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(134, 23);
            this.btnCancelarReserva.TabIndex = 8;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnGenerarModificacionReserva
            // 
            this.btnGenerarModificacionReserva.Location = new System.Drawing.Point(86, 102);
            this.btnGenerarModificacionReserva.Name = "btnGenerarModificacionReserva";
            this.btnGenerarModificacionReserva.Size = new System.Drawing.Size(137, 23);
            this.btnGenerarModificacionReserva.TabIndex = 10;
            this.btnGenerarModificacionReserva.Text = "Generar modificacion";
            this.btnGenerarModificacionReserva.UseVisualStyleBackColor = true;
            this.btnGenerarModificacionReserva.Click += new System.EventHandler(this.btnGenerarModificacionReserva_Click);
            // 
            // frmFuncionalidadesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 336);
            this.Controls.Add(this.btnGenerarModificacionReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarReserva);
            this.Name = "frmFuncionalidadesCliente";
            this.Text = "Funcionalidades cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnGenerarModificacionReserva;

    }
}