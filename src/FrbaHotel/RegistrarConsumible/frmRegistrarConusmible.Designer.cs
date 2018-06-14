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
            this.btnRegistrarConsumible = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lvConsumibles = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoverConsumible = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbConsumible = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Consumible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // btnRegistrarConsumible
            // 
            this.btnRegistrarConsumible.Location = new System.Drawing.Point(90, 174);
            this.btnRegistrarConsumible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarConsumible.Name = "btnRegistrarConsumible";
            this.btnRegistrarConsumible.Size = new System.Drawing.Size(106, 42);
            this.btnRegistrarConsumible.TabIndex = 5;
            this.btnRegistrarConsumible.Text = "Registrar Consumible";
            this.btnRegistrarConsumible.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumible.Click += new System.EventHandler(this.btnRegistrarConsumible_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(119, 121);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(66, 22);
            this.tbCantidad.TabIndex = 8;
            // 
            // lvConsumibles
            // 
            this.lvConsumibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio});
            this.lvConsumibles.HideSelection = false;
            this.lvConsumibles.Location = new System.Drawing.Point(272, 68);
            this.lvConsumibles.Margin = new System.Windows.Forms.Padding(4);
            this.lvConsumibles.Name = "lvConsumibles";
            this.lvConsumibles.Size = new System.Drawing.Size(281, 128);
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
            this.Precio.DisplayIndex = 1;
            this.Precio.Text = "Precio";
            // 
            // Descripcion
            // 
            this.Descripcion.DisplayIndex = 2;
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 81;
            // 
            // Cantidad
            // 
            this.Cantidad.DisplayIndex = 3;
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 69;
            // 
            // btnRemoverConsumible
            // 
            this.btnRemoverConsumible.Location = new System.Drawing.Point(561, 118);
            this.btnRemoverConsumible.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverConsumible.Name = "btnRemoverConsumible";
            this.btnRemoverConsumible.Size = new System.Drawing.Size(100, 28);
            this.btnRemoverConsumible.TabIndex = 10;
            this.btnRemoverConsumible.Text = "Remover";
            this.btnRemoverConsumible.UseVisualStyleBackColor = true;
            this.btnRemoverConsumible.Click += new System.EventHandler(this.btnRemoverConsumible_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(361, 219);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 39);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbConsumible
            // 
            this.cbConsumible.FormattingEnabled = true;
            this.cbConsumible.Location = new System.Drawing.Point(119, 68);
            this.cbConsumible.Name = "cbConsumible";
            this.cbConsumible.Size = new System.Drawing.Size(121, 24);
            this.cbConsumible.TabIndex = 12;
            // 
            // frmRegistrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 280);
            this.Controls.Add(this.cbConsumible);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemoverConsumible);
            this.Controls.Add(this.lvConsumibles);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btnRegistrarConsumible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarConsumible";
            this.Text = "Registrar consumible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarConsumible;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.ListView lvConsumibles;
        private System.Windows.Forms.Button btnRemoverConsumible;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.ColumnHeader Codigo;
        public System.Windows.Forms.ColumnHeader Precio;
        public System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ComboBox cbConsumible;
        private System.Windows.Forms.ColumnHeader Cantidad;
    }
}