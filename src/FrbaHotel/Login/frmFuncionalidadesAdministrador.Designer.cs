namespace FrbaHotel.Login
{
    partial class frmFuncionalidadesAdministrador
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.btnABMRegimenEstadia = new System.Windows.Forms.Button();
            this.btnABMHabitacion = new System.Windows.Forms.Button();
            this.btnABMHotel = new System.Windows.Forms.Button();
            this.btnABMUsuario = new System.Windows.Forms.Button();
            this.btnABMRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(47, 301);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(61, 28);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.Text = "<< Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Location = new System.Drawing.Point(146, 245);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(150, 23);
            this.btnListadoEstadistico.TabIndex = 21;
            this.btnListadoEstadistico.Text = "Listado estadistico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            // 
            // btnABMRegimenEstadia
            // 
            this.btnABMRegimenEstadia.Location = new System.Drawing.Point(146, 185);
            this.btnABMRegimenEstadia.Name = "btnABMRegimenEstadia";
            this.btnABMRegimenEstadia.Size = new System.Drawing.Size(150, 23);
            this.btnABMRegimenEstadia.TabIndex = 20;
            this.btnABMRegimenEstadia.Text = "ABM Regimen de Estadia";
            this.btnABMRegimenEstadia.UseVisualStyleBackColor = true;
            // 
            // btnABMHabitacion
            // 
            this.btnABMHabitacion.Location = new System.Drawing.Point(239, 131);
            this.btnABMHabitacion.Name = "btnABMHabitacion";
            this.btnABMHabitacion.Size = new System.Drawing.Size(109, 23);
            this.btnABMHabitacion.TabIndex = 19;
            this.btnABMHabitacion.Text = "ABM de Habitacion";
            this.btnABMHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnABMHotel
            // 
            this.btnABMHotel.Location = new System.Drawing.Point(101, 131);
            this.btnABMHotel.Name = "btnABMHotel";
            this.btnABMHotel.Size = new System.Drawing.Size(96, 23);
            this.btnABMHotel.TabIndex = 18;
            this.btnABMHotel.Text = "ABM de Hotel";
            this.btnABMHotel.UseVisualStyleBackColor = true;
            // 
            // btnABMUsuario
            // 
            this.btnABMUsuario.Location = new System.Drawing.Point(239, 77);
            this.btnABMUsuario.Name = "btnABMUsuario";
            this.btnABMUsuario.Size = new System.Drawing.Size(107, 23);
            this.btnABMUsuario.TabIndex = 17;
            this.btnABMUsuario.Text = "ABM de Usuario";
            this.btnABMUsuario.UseVisualStyleBackColor = true;
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(101, 77);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(96, 23);
            this.btnABMRol.TabIndex = 16;
            this.btnABMRol.Text = "ABM de Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABMRol_Click);
            // 
            // frmFuncionalidadesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 398);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnListadoEstadistico);
            this.Controls.Add(this.btnABMRegimenEstadia);
            this.Controls.Add(this.btnABMHabitacion);
            this.Controls.Add(this.btnABMHotel);
            this.Controls.Add(this.btnABMUsuario);
            this.Controls.Add(this.btnABMRol);
            this.Name = "frmFuncionalidadesAdministrador";
            this.Text = "frmFuncionalidadesAdministrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Button btnABMRegimenEstadia;
        private System.Windows.Forms.Button btnABMHabitacion;
        private System.Windows.Forms.Button btnABMHotel;
        private System.Windows.Forms.Button btnABMUsuario;
        private System.Windows.Forms.Button btnABMRol;
    }
}