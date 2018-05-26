namespace FrbaHotel.Login
{
    partial class frmSeleccionRol
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
            this.cbListaRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbListaRoles
            // 
            this.cbListaRoles.FormattingEnabled = true;
            this.cbListaRoles.Location = new System.Drawing.Point(102, 92);
            this.cbListaRoles.Margin = new System.Windows.Forms.Padding(4);
            this.cbListaRoles.Name = "cbListaRoles";
            this.cbListaRoles.Size = new System.Drawing.Size(160, 24);
            this.cbListaRoles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Continuar como:";
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(138, 150);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(87, 25);
            this.continuar.TabIndex = 2;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // frmSeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 227);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbListaRoles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSeleccionRol";
            this.Text = "Seleccion de rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListaRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continuar;
    }
}