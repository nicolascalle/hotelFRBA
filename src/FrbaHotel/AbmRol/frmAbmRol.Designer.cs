namespace FrbaHotel.AbmRol
{
    partial class frmABMRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvRol = new System.Windows.Forms.ListView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.frmModificacion = new System.Windows.Forms.Button();
            this.frmInhabilitar = new System.Windows.Forms.Button();
            this.frmAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            // 
            // tbNombreRol
            // 
            this.tbNombreRol.Location = new System.Drawing.Point(73, 275);
            this.tbNombreRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombreRol.Name = "tbNombreRol";
            this.tbNombreRol.Size = new System.Drawing.Size(110, 20);
            this.tbNombreRol.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "ABM Rol";
            // 
            // lvRol
            // 
            this.lvRol.FullRowSelect = true;
            this.lvRol.GridLines = true;
            this.lvRol.Location = new System.Drawing.Point(16, 50);
            this.lvRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvRol.MultiSelect = false;
            this.lvRol.Name = "lvRol";
            this.lvRol.Size = new System.Drawing.Size(292, 206);
            this.lvRol.TabIndex = 24;
            this.lvRol.UseCompatibleStateImageBehavior = false;
            this.lvRol.View = System.Windows.Forms.View.Details;
            this.lvRol.SelectedIndexChanged += new System.EventHandler(this.lvRol_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(318, 270);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 22);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmModificacion
            // 
            this.frmModificacion.Location = new System.Drawing.Point(318, 155);
            this.frmModificacion.Name = "frmModificacion";
            this.frmModificacion.Size = new System.Drawing.Size(80, 22);
            this.frmModificacion.TabIndex = 22;
            this.frmModificacion.Text = "Modificacion";
            this.frmModificacion.UseVisualStyleBackColor = true;
            this.frmModificacion.Click += new System.EventHandler(this.frmModificacion_Click);
            // 
            // frmInhabilitar
            // 
            this.frmInhabilitar.Location = new System.Drawing.Point(318, 126);
            this.frmInhabilitar.Name = "frmInhabilitar";
            this.frmInhabilitar.Size = new System.Drawing.Size(80, 22);
            this.frmInhabilitar.TabIndex = 21;
            this.frmInhabilitar.Text = "Inhabilitar";
            this.frmInhabilitar.UseVisualStyleBackColor = true;
            this.frmInhabilitar.Click += new System.EventHandler(this.frmInhabilitar_Click);
            // 
            // frmAlta
            // 
            this.frmAlta.Location = new System.Drawing.Point(318, 98);
            this.frmAlta.Name = "frmAlta";
            this.frmAlta.Size = new System.Drawing.Size(80, 22);
            this.frmAlta.TabIndex = 20;
            this.frmAlta.Text = "Alta";
            this.frmAlta.UseVisualStyleBackColor = true;
            this.frmAlta.Click += new System.EventHandler(this.frmAlta_Click);
            // 
            // frmABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(410, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvRol);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.frmModificacion);
            this.Controls.Add(this.frmInhabilitar);
            this.Controls.Add(this.frmAlta);
            this.Name = "frmABMRol";
            this.Text = "ABM Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvRol;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button frmModificacion;
        private System.Windows.Forms.Button frmInhabilitar;
        private System.Windows.Forms.Button frmAlta;

    }
}