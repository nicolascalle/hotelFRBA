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
            this.btnABMHabitacion = new System.Windows.Forms.Button();
            this.btnABMHotel = new System.Windows.Forms.Button();
            this.btnABMUsuario = new System.Windows.Forms.Button();
            this.btnABMRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 283);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(81, 34);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.Text = "<< Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Location = new System.Drawing.Point(155, 220);
            this.btnListadoEstadistico.Margin = new System.Windows.Forms.Padding(4);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(183, 42);
            this.btnListadoEstadistico.TabIndex = 21;
            this.btnListadoEstadistico.Text = "Listado estadistico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // btnABMHabitacion
            // 
            this.btnABMHabitacion.Location = new System.Drawing.Point(254, 149);
            this.btnABMHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnABMHabitacion.Name = "btnABMHabitacion";
            this.btnABMHabitacion.Size = new System.Drawing.Size(183, 42);
            this.btnABMHabitacion.TabIndex = 19;
            this.btnABMHabitacion.Text = "ABM de Habitacion";
            this.btnABMHabitacion.UseVisualStyleBackColor = true;
            this.btnABMHabitacion.Click += new System.EventHandler(this.btnABMHabitacion_Click);
            // 
            // btnABMHotel
            // 
            this.btnABMHotel.Location = new System.Drawing.Point(37, 83);
            this.btnABMHotel.Margin = new System.Windows.Forms.Padding(4);
            this.btnABMHotel.Name = "btnABMHotel";
            this.btnABMHotel.Size = new System.Drawing.Size(183, 43);
            this.btnABMHotel.TabIndex = 18;
            this.btnABMHotel.Text = "ABM de Hotel";
            this.btnABMHotel.UseVisualStyleBackColor = true;
            this.btnABMHotel.Click += new System.EventHandler(this.btnABMHotel_Click);
            // 
            // btnABMUsuario
            // 
            this.btnABMUsuario.Location = new System.Drawing.Point(254, 83);
            this.btnABMUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnABMUsuario.Name = "btnABMUsuario";
            this.btnABMUsuario.Size = new System.Drawing.Size(183, 43);
            this.btnABMUsuario.TabIndex = 17;
            this.btnABMUsuario.Text = "ABM de Usuario";
            this.btnABMUsuario.UseVisualStyleBackColor = true;
            this.btnABMUsuario.Click += new System.EventHandler(this.btnABMUsuario_Click);
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(37, 149);
            this.btnABMRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(183, 42);
            this.btnABMRol.TabIndex = 16;
            this.btnABMRol.Text = "ABM de Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABMRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Administrador";
            // 
            // frmFuncionalidadesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnListadoEstadistico);
            this.Controls.Add(this.btnABMHabitacion);
            this.Controls.Add(this.btnABMHotel);
            this.Controls.Add(this.btnABMUsuario);
            this.Controls.Add(this.btnABMRol);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFuncionalidadesAdministrador";
            this.Text = "frmFuncionalidadesAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Button btnABMHabitacion;
        private System.Windows.Forms.Button btnABMHotel;
        private System.Windows.Forms.Button btnABMUsuario;
        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Label label1;
    }
}