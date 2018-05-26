namespace FrbaHotel.Login
{
    partial class frmFuncionalidadesRecepcionista
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
            this.btnGenerarModificacionReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistroConsumible = new System.Windows.Forms.Button();
            this.btnRegistroEstadia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarModificacionReserva
            // 
            this.btnGenerarModificacionReserva.Location = new System.Drawing.Point(146, 267);
            this.btnGenerarModificacionReserva.Name = "btnGenerarModificacionReserva";
            this.btnGenerarModificacionReserva.Size = new System.Drawing.Size(137, 23);
            this.btnGenerarModificacionReserva.TabIndex = 18;
            this.btnGenerarModificacionReserva.Text = "Generar modificacion";
            this.btnGenerarModificacionReserva.UseVisualStyleBackColor = true;
            this.btnGenerarModificacionReserva.Click += new System.EventHandler(this.btnGenerarModificacionReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reservas:";
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Location = new System.Drawing.Point(40, 90);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(75, 23);
            this.btnABMCliente.TabIndex = 19;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistroConsumible
            // 
            this.btnRegistroConsumible.Location = new System.Drawing.Point(40, 146);
            this.btnRegistroConsumible.Name = "btnRegistroConsumible";
            this.btnRegistroConsumible.Size = new System.Drawing.Size(140, 23);
            this.btnRegistroConsumible.TabIndex = 21;
            this.btnRegistroConsumible.Text = "Registrar consumible";
            this.btnRegistroConsumible.UseVisualStyleBackColor = true;
            this.btnRegistroConsumible.Click += new System.EventHandler(this.btnRegistroConsumible_Click);
            // 
            // btnRegistroEstadia
            // 
            this.btnRegistroEstadia.Location = new System.Drawing.Point(249, 166);
            this.btnRegistroEstadia.Name = "btnRegistroEstadia";
            this.btnRegistroEstadia.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroEstadia.TabIndex = 22;
            this.btnRegistroEstadia.Text = "Registrar estadia";
            this.btnRegistroEstadia.UseVisualStyleBackColor = true;
            // 
            // frmFuncionalidadesRecepcionista
            // 
            this.ClientSize = new System.Drawing.Size(425, 442);
            this.Controls.Add(this.btnRegistroEstadia);
            this.Controls.Add(this.btnRegistroConsumible);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnABMCliente);
            this.Controls.Add(this.btnGenerarModificacionReserva);
            this.Controls.Add(this.label1);
            this.Name = "frmFuncionalidadesRecepcionista";
            this.Text = "frmFuncionalidadesRecepcionista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMClientes;
        private System.Windows.Forms.Button btnRegistrarEstadia;
        private System.Windows.Forms.Button btnRegistrarConsumible;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnGenerarReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarModificacionReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistroConsumible;
        private System.Windows.Forms.Button btnRegistroEstadia;
    }
}