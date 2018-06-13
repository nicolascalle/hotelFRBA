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
            this.components = new System.ComponentModel.Container();
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.HabitacionTableAdapter();
            this.regimenHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regimen_HotelTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.Regimen_HotelTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRegimenesDisponibles = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tbEleccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenHotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataMember = "Habitacion";
            this.habitacionBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // habitacionTableAdapter
            // 
            this.habitacionTableAdapter.ClearBeforeFill = true;
            // 
            // regimenHotelBindingSource
            // 
            this.regimenHotelBindingSource.DataMember = "Regimen_Hotel";
            this.regimenHotelBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // regimen_HotelTableAdapter
            // 
            this.regimen_HotelTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Estos son los regimenes disponibles en este hotel:";
            // 
            // dgvRegimenesDisponibles
            // 
            this.dgvRegimenesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegimenesDisponibles.Location = new System.Drawing.Point(24, 75);
            this.dgvRegimenesDisponibles.Name = "dgvRegimenesDisponibles";
            this.dgvRegimenesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegimenesDisponibles.Size = new System.Drawing.Size(240, 150);
            this.dgvRegimenesDisponibles.TabIndex = 56;
            this.dgvRegimenesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegimenesDisponibles_CellContentClick);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(285, 106);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(88, 34);
            this.btnSelecionar.TabIndex = 57;
            this.btnSelecionar.Text = "Seleccionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // tbEleccion
            // 
            this.tbEleccion.Location = new System.Drawing.Point(285, 164);
            this.tbEleccion.Name = "tbEleccion";
            this.tbEleccion.Size = new System.Drawing.Size(100, 20);
            this.tbEleccion.TabIndex = 58;
            // 
            // frmEleccionDeRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.tbEleccion);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgvRegimenesDisponibles);
            this.Controls.Add(this.label2);
            this.Name = "frmEleccionDeRegimen";
            this.Text = "frmEleccionDeRegimen";
            this.Load += new System.EventHandler(this.frmEleccionDeRegimen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenHotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private GD1C2018DataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private System.Windows.Forms.BindingSource regimenHotelBindingSource;
        private GD1C2018DataSetTableAdapters.Regimen_HotelTableAdapter regimen_HotelTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRegimenesDisponibles;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox tbEleccion;
    }
}