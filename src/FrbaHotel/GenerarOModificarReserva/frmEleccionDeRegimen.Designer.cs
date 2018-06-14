namespace FrbaHotel.GenerarOModificarReserva
{
    partial class frmEleccionDeRegimen
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
            this.button1 = new System.Windows.Forms.Button();
            this.lvRegimenes = new System.Windows.Forms.ListView();
            this.Regimenes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvRegimenes
            // 
            this.lvRegimenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Regimenes});
            this.lvRegimenes.FullRowSelect = true;
            this.lvRegimenes.GridLines = true;
            this.lvRegimenes.Location = new System.Drawing.Point(38, 34);
            this.lvRegimenes.Margin = new System.Windows.Forms.Padding(2);
            this.lvRegimenes.MultiSelect = false;
            this.lvRegimenes.Name = "lvRegimenes";
            this.lvRegimenes.Size = new System.Drawing.Size(311, 145);
            this.lvRegimenes.TabIndex = 40;
            this.lvRegimenes.UseCompatibleStateImageBehavior = false;
            this.lvRegimenes.View = System.Windows.Forms.View.Details;
            // 
            // Regimenes
            // 
            this.Regimenes.Text = "Regimenes";
            this.Regimenes.Width = 98;
            // 
            // frmEleccionDeRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 255);
            this.Controls.Add(this.lvRegimenes);
            this.Controls.Add(this.button1);
            this.Name = "frmEleccionDeRegimen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvRegimenes;
        private System.Windows.Forms.ColumnHeader Regimenes;
    }
}