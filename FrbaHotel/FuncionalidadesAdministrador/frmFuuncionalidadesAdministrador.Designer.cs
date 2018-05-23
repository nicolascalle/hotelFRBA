namespace FrbaHotel.FuncionalidadesAdministrador
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
            this.btnABMRol = new System.Windows.Forms.Button();
            this.btnABMUsuario = new System.Windows.Forms.Button();
            this.btnABMHotel = new System.Windows.Forms.Button();
            this.btnABMHabitacion = new System.Windows.Forms.Button();
            this.btnABMRegimenEstadia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(76, 102);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(96, 23);
            this.btnABMRol.TabIndex = 0;
            this.btnABMRol.Text = "ABM de Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABMRol_Click);
            // 
            // btnABMUsuario
            // 
            this.btnABMUsuario.Location = new System.Drawing.Point(214, 102);
            this.btnABMUsuario.Name = "btnABMUsuario";
            this.btnABMUsuario.Size = new System.Drawing.Size(107, 23);
            this.btnABMUsuario.TabIndex = 1;
            this.btnABMUsuario.Text = "ABM de Usuario";
            this.btnABMUsuario.UseVisualStyleBackColor = true;
            this.btnABMUsuario.Click += new System.EventHandler(this.btnABMUsuario_Click);
            // 
            // btnABMHotel
            // 
            this.btnABMHotel.Location = new System.Drawing.Point(76, 156);
            this.btnABMHotel.Name = "btnABMHotel";
            this.btnABMHotel.Size = new System.Drawing.Size(96, 23);
            this.btnABMHotel.TabIndex = 2;
            this.btnABMHotel.Text = "ABM de Hotel";
            this.btnABMHotel.UseVisualStyleBackColor = true;
            this.btnABMHotel.Click += new System.EventHandler(this.btnABMHotel_Click);
            // 
            // btnABMHabitacion
            // 
            this.btnABMHabitacion.Location = new System.Drawing.Point(214, 156);
            this.btnABMHabitacion.Name = "btnABMHabitacion";
            this.btnABMHabitacion.Size = new System.Drawing.Size(109, 23);
            this.btnABMHabitacion.TabIndex = 3;
            this.btnABMHabitacion.Text = "ABM de Habitacion";
            this.btnABMHabitacion.UseVisualStyleBackColor = true;
            this.btnABMHabitacion.Click += new System.EventHandler(this.btnABMHabitacion_Click);
            // 
            // btnABMRegimenEstadia
            // 
            this.btnABMRegimenEstadia.Location = new System.Drawing.Point(121, 210);
            this.btnABMRegimenEstadia.Name = "btnABMRegimenEstadia";
            this.btnABMRegimenEstadia.Size = new System.Drawing.Size(150, 23);
            this.btnABMRegimenEstadia.TabIndex = 4;
            this.btnABMRegimenEstadia.Text = "ABM Regimen de Estadia";
            this.btnABMRegimenEstadia.UseVisualStyleBackColor = true;
            this.btnABMRegimenEstadia.Click += new System.EventHandler(this.btnABMRegimenEstadia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione lo que desee hacer:";
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Location = new System.Drawing.Point(121, 270);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(144, 23);
            this.btnListadoEstadistico.TabIndex = 6;
            this.btnListadoEstadistico.Text = "Listado estadistico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // frmFuncionalidadesAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 395);
            this.Controls.Add(this.btnListadoEstadistico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnABMRegimenEstadia);
            this.Controls.Add(this.btnABMHabitacion);
            this.Controls.Add(this.btnABMHotel);
            this.Controls.Add(this.btnABMUsuario);
            this.Controls.Add(this.btnABMRol);
            this.Name = "frmFuncionalidadesAdministrador";
            this.Text = "Funcionalidades administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Button btnABMUsuario;
        private System.Windows.Forms.Button btnABMHotel;
        private System.Windows.Forms.Button btnABMHabitacion;
        private System.Windows.Forms.Button btnABMRegimenEstadia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListadoEstadistico;
    }
}