namespace FrbaHotel.FacturarEstadia
{
    partial class frmFacturarEstadia
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
            this.btnFacturarEstadia = new System.Windows.Forms.Button();
            this.tbNroReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarConsumibles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaDePago = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFacturarEstadia
            // 
            this.btnFacturarEstadia.Location = new System.Drawing.Point(143, 233);
            this.btnFacturarEstadia.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturarEstadia.Name = "btnFacturarEstadia";
            this.btnFacturarEstadia.Size = new System.Drawing.Size(172, 41);
            this.btnFacturarEstadia.TabIndex = 0;
            this.btnFacturarEstadia.Text = "Facturar estadia";
            this.btnFacturarEstadia.UseVisualStyleBackColor = true;
            this.btnFacturarEstadia.Click += new System.EventHandler(this.btnFacturarEstadia_Click);
            // 
            // tbNroReserva
            // 
            this.tbNroReserva.Location = new System.Drawing.Point(47, 189);
            this.tbNroReserva.Margin = new System.Windows.Forms.Padding(4);
            this.tbNroReserva.Name = "tbNroReserva";
            this.tbNroReserva.Size = new System.Drawing.Size(184, 22);
            this.tbNroReserva.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese numero de reserva";
            // 
            // btnRegistrarConsumibles
            // 
            this.btnRegistrarConsumibles.Location = new System.Drawing.Point(159, 74);
            this.btnRegistrarConsumibles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarConsumibles.Name = "btnRegistrarConsumibles";
            this.btnRegistrarConsumibles.Size = new System.Drawing.Size(143, 50);
            this.btnRegistrarConsumibles.TabIndex = 6;
            this.btnRegistrarConsumibles.Text = "Registrar consumibles";
            this.btnRegistrarConsumibles.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumibles.Click += new System.EventHandler(this.btnRegistrarConsumibles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese items consumidos";
            // 
            // cbFormaDePago
            // 
            this.cbFormaDePago.FormattingEnabled = true;
            this.cbFormaDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Credito",
            "Debito"});
            this.cbFormaDePago.Location = new System.Drawing.Point(273, 187);
            this.cbFormaDePago.Name = "cbFormaDePago";
            this.cbFormaDePago.Size = new System.Drawing.Size(121, 24);
            this.cbFormaDePago.TabIndex = 8;
            this.cbFormaDePago.Text = "Efectivo";
            // 
            // frmFacturarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 301);
            this.Controls.Add(this.cbFormaDePago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarConsumibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNroReserva);
            this.Controls.Add(this.btnFacturarEstadia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFacturarEstadia";
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturarEstadia;
        private System.Windows.Forms.TextBox tbNroReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarConsumibles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormaDePago;
    }
}