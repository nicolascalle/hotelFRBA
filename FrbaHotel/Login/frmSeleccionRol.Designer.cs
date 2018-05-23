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
            this.SuspendLayout();
            // 
            // cbListaRoles
            // 
            this.cbListaRoles.FormattingEnabled = true;
            this.cbListaRoles.Location = new System.Drawing.Point(53, 58);
            this.cbListaRoles.Name = "cbListaRoles";
            this.cbListaRoles.Size = new System.Drawing.Size(121, 21);
            this.cbListaRoles.TabIndex = 0;
            this.cbListaRoles.SelectedIndexChanged += new System.EventHandler(this.cbListaRoles_SelectedIndexChanged);
            // 
            // frmSeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbListaRoles);
            this.Name = "frmSeleccionRol";
            this.Text = "Seleccion de rol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListaRoles;
    }
}