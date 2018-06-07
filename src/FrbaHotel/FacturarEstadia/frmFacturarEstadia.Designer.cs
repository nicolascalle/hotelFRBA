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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarConsumibles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFacturarEstadia
            // 
            this.btnFacturarEstadia.Location = new System.Drawing.Point(196, 191);
            this.btnFacturarEstadia.Name = "btnFacturarEstadia";
            this.btnFacturarEstadia.Size = new System.Drawing.Size(129, 33);
            this.btnFacturarEstadia.TabIndex = 0;
            this.btnFacturarEstadia.Text = "Facturar estadia";
            this.btnFacturarEstadia.UseVisualStyleBackColor = true;
            this.btnFacturarEstadia.Click += new System.EventHandler(this.btnFacturarEstadia_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese numero de reserva";
            // 
            // btnRegistrarConsumibles
            // 
            this.btnRegistrarConsumibles.Location = new System.Drawing.Point(121, 57);
            this.btnRegistrarConsumibles.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarConsumibles.Name = "btnRegistrarConsumibles";
            this.btnRegistrarConsumibles.Size = new System.Drawing.Size(107, 41);
            this.btnRegistrarConsumibles.TabIndex = 6;
            this.btnRegistrarConsumibles.Text = "Registrar consumibles";
            this.btnRegistrarConsumibles.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumibles.Click += new System.EventHandler(this.btnRegistrarConsumibles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese items consumidos";
            // 
            // frmFacturarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarConsumibles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFacturarEstadia);
            this.Name = "frmFacturarEstadia";
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturarEstadia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarConsumibles;
        private System.Windows.Forms.Label label2;
    }
}