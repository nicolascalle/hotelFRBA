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
            this.cbListaRoles.Location = new System.Drawing.Point(76, 75);
            this.cbListaRoles.Name = "cbListaRoles";
            this.cbListaRoles.Size = new System.Drawing.Size(121, 21);
            this.cbListaRoles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Continuar como:";
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(104, 118);
            this.continuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(65, 24);
            this.continuar.TabIndex = 2;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // frmSeleccionRol
            // 
            this.AcceptButton = this.continuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 184);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbListaRoles);
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