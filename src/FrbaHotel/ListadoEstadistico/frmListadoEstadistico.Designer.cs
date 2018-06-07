namespace FrbaHotel.ListadoEstadistico
{
    partial class frmListadoEstadistico
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
            this.cbTrimestre = new System.Windows.Forms.ComboBox();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvListadoEstadistico = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cbTrimestre
            // 
            this.cbTrimestre.FormattingEnabled = true;
            this.cbTrimestre.Location = new System.Drawing.Point(398, 113);
            this.cbTrimestre.Name = "cbTrimestre";
            this.cbTrimestre.Size = new System.Drawing.Size(100, 24);
            this.cbTrimestre.TabIndex = 0;
            // 
            // cbConsulta
            // 
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(28, 67);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(470, 24);
            this.cbConsulta.TabIndex = 1;
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // cbAnio
            // 
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Location = new System.Drawing.Point(271, 113);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(100, 24);
            this.cbAnio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado Estadístico";
            // 
            // lvListadoEstadistico
            // 
            this.lvListadoEstadistico.FullRowSelect = true;
            this.lvListadoEstadistico.GridLines = true;
            this.lvListadoEstadistico.Location = new System.Drawing.Point(28, 214);
            this.lvListadoEstadistico.MultiSelect = false;
            this.lvListadoEstadistico.Name = "lvListadoEstadistico";
            this.lvListadoEstadistico.Size = new System.Drawing.Size(470, 187);
            this.lvListadoEstadistico.TabIndex = 25;
            this.lvListadoEstadistico.UseCompatibleStateImageBehavior = false;
            this.lvListadoEstadistico.View = System.Windows.Forms.View.Details;
            // 
            // frmListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 435);
            this.Controls.Add(this.lvListadoEstadistico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.cbTrimestre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListadoEstadistico";
            this.Text = "Listado estadistico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrimestre;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvListadoEstadistico;
    }
}