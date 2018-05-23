namespace FrbaHotel.FuncionalidadesRecepcionista
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
            this.btnABMClientes = new System.Windows.Forms.Button();
            this.btnGenerarModificacionReserva = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarEstadia = new System.Windows.Forms.Button();
            this.btnRegistrarConsumible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMClientes
            // 
            this.btnABMClientes.Location = new System.Drawing.Point(87, 45);
            this.btnABMClientes.Name = "btnABMClientes";
            this.btnABMClientes.Size = new System.Drawing.Size(110, 23);
            this.btnABMClientes.TabIndex = 0;
            this.btnABMClientes.Text = "ABM de Clientes";
            this.btnABMClientes.UseVisualStyleBackColor = true;
            this.btnABMClientes.Click += new System.EventHandler(this.btnABMClientes_Click);
            // 
            // btnGenerarModificacionReserva
            // 
            this.btnGenerarModificacionReserva.Location = new System.Drawing.Point(72, 204);
            this.btnGenerarModificacionReserva.Name = "btnGenerarModificacionReserva";
            this.btnGenerarModificacionReserva.Size = new System.Drawing.Size(145, 23);
            this.btnGenerarModificacionReserva.TabIndex = 2;
            this.btnGenerarModificacionReserva.Text = "Generar modificacion";
            this.btnGenerarModificacionReserva.UseVisualStyleBackColor = true;
            this.btnGenerarModificacionReserva.Click += new System.EventHandler(this.btnGenerarReserva_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(242, 204);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(127, 23);
            this.btnCancelarReserva.TabIndex = 4;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reservas:";
            // 
            // btnRegistrarEstadia
            // 
            this.btnRegistrarEstadia.Location = new System.Drawing.Point(222, 45);
            this.btnRegistrarEstadia.Name = "btnRegistrarEstadia";
            this.btnRegistrarEstadia.Size = new System.Drawing.Size(130, 23);
            this.btnRegistrarEstadia.TabIndex = 6;
            this.btnRegistrarEstadia.Text = "Registrar Estadia";
            this.btnRegistrarEstadia.UseVisualStyleBackColor = true;
            this.btnRegistrarEstadia.Click += new System.EventHandler(this.btnRegistrarEstadia_Click);
            // 
            // btnRegistrarConsumible
            // 
            this.btnRegistrarConsumible.Location = new System.Drawing.Point(142, 90);
            this.btnRegistrarConsumible.Name = "btnRegistrarConsumible";
            this.btnRegistrarConsumible.Size = new System.Drawing.Size(147, 23);
            this.btnRegistrarConsumible.TabIndex = 7;
            this.btnRegistrarConsumible.Text = "Registrar consumible";
            this.btnRegistrarConsumible.UseVisualStyleBackColor = true;
            // 
            // frmFuncionalidadesRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 382);
            this.Controls.Add(this.btnRegistrarConsumible);
            this.Controls.Add(this.btnRegistrarEstadia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnGenerarModificacionReserva);
            this.Controls.Add(this.btnABMClientes);
            this.Name = "frmFuncionalidadesRecepcionista";
            this.Text = "Funcionalidades recepcionista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMClientes;
        private System.Windows.Forms.Button btnGenerarModificacionReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarEstadia;
        private System.Windows.Forms.Button btnRegistrarConsumible;
    }
}