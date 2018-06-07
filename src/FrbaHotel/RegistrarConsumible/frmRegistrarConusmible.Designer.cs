namespace FrbaHotel.RegistrarConsumible
{
    partial class frmRegistrarConsumible
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPrecioConsumible = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrarConsumible = new System.Windows.Forms.Button();
            this.tbCodigoConsumible = new System.Windows.Forms.TextBox();
            this.tbDescripcionConsumible = new System.Windows.Forms.TextBox();
            this.lvConsumibles = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoverConsumible = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioConsumible)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Consumible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // nudPrecioConsumible
            // 
            this.nudPrecioConsumible.DecimalPlaces = 2;
            this.nudPrecioConsumible.Location = new System.Drawing.Point(111, 120);
            this.nudPrecioConsumible.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecioConsumible.Name = "nudPrecioConsumible";
            this.nudPrecioConsumible.Size = new System.Drawing.Size(90, 20);
            this.nudPrecioConsumible.TabIndex = 4;
            // 
            // btnRegistrarConsumible
            // 
            this.btnRegistrarConsumible.Location = new System.Drawing.Point(111, 204);
            this.btnRegistrarConsumible.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarConsumible.Name = "btnRegistrarConsumible";
            this.btnRegistrarConsumible.Size = new System.Drawing.Size(87, 37);
            this.btnRegistrarConsumible.TabIndex = 5;
            this.btnRegistrarConsumible.Text = "Registrar Consumible";
            this.btnRegistrarConsumible.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumible.Click += new System.EventHandler(this.btnRegistrarConsumible_Click);
            // 
            // tbCodigoConsumible
            // 
            this.tbCodigoConsumible.Location = new System.Drawing.Point(111, 72);
            this.tbCodigoConsumible.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoConsumible.MaxLength = 10;
            this.tbCodigoConsumible.Name = "tbCodigoConsumible";
            this.tbCodigoConsumible.Size = new System.Drawing.Size(90, 20);
            this.tbCodigoConsumible.TabIndex = 6;
            // 
            // tbDescripcionConsumible
            // 
            this.tbDescripcionConsumible.Location = new System.Drawing.Point(111, 160);
            this.tbDescripcionConsumible.Name = "tbDescripcionConsumible";
            this.tbDescripcionConsumible.Size = new System.Drawing.Size(90, 20);
            this.tbDescripcionConsumible.TabIndex = 8;
            // 
            // lvConsumibles
            // 
            this.lvConsumibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Precio,
            this.Descripcion});
            this.lvConsumibles.HideSelection = false;
            this.lvConsumibles.Location = new System.Drawing.Point(243, 72);
            this.lvConsumibles.Name = "lvConsumibles";
            this.lvConsumibles.Size = new System.Drawing.Size(212, 105);
            this.lvConsumibles.TabIndex = 9;
            this.lvConsumibles.UseCompatibleStateImageBehavior = false;
            this.lvConsumibles.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 67;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 81;
            // 
            // btnRemoverConsumible
            // 
            this.btnRemoverConsumible.Location = new System.Drawing.Point(471, 112);
            this.btnRemoverConsumible.Name = "btnRemoverConsumible";
            this.btnRemoverConsumible.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverConsumible.TabIndex = 10;
            this.btnRemoverConsumible.Text = "Remover";
            this.btnRemoverConsumible.UseVisualStyleBackColor = true;
            this.btnRemoverConsumible.Click += new System.EventHandler(this.btnRemoverConsumible_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(384, 218);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmRegistrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 269);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemoverConsumible);
            this.Controls.Add(this.lvConsumibles);
            this.Controls.Add(this.tbDescripcionConsumible);
            this.Controls.Add(this.tbCodigoConsumible);
            this.Controls.Add(this.btnRegistrarConsumible);
            this.Controls.Add(this.nudPrecioConsumible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarConsumible";
            this.Text = "Registrar consumible";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioConsumible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPrecioConsumible;
        private System.Windows.Forms.Button btnRegistrarConsumible;
        private System.Windows.Forms.TextBox tbCodigoConsumible;
        private System.Windows.Forms.TextBox tbDescripcionConsumible;
        private System.Windows.Forms.ListView lvConsumibles;
        private System.Windows.Forms.Button btnRemoverConsumible;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.ColumnHeader Codigo;
        public System.Windows.Forms.ColumnHeader Precio;
        public System.Windows.Forms.ColumnHeader Descripcion;
    }
}