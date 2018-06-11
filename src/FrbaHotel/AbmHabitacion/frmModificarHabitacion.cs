using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrbaHotel.AbmHabitacion
{
    public partial class frmModificarHabitacion : Form
    {
        string numeroHabitacion;
        string codigoHotel;
        SqlDataReader dataReader;
        bool estaHabilitada;
        public frmModificarHabitacion(string numeroHabitacion, string codigoHotel, SqlDataReader dataReader)
        {
            InitializeComponent();
            this.numeroHabitacion = numeroHabitacion;
            this.codigoHotel = codigoHotel;
            this.dataReader = dataReader;
            this.mostrarHabitacion();
        }

        public void mostrarHabitacion()
        {
            tbNumHab.Text = numeroHabitacion;
            tbNumHab.Enabled = false;
            tbcodHotel.Text = codigoHotel;
            tbcodHotel.Enabled = false;
            tbPiso.Text = dataReader["habi_piso"].ToString();
            cbUbicacion.Text = dataReader["habi_vista_exterior"].ToString();
            cbTipoHab.Text = dataReader["habi_tipo_codigo"].ToString();
            cbTipoHab.Enabled = false;
            tbDescripcion.Text = dataReader["habi_descripcion"].ToString();
            estaHabilitada = Convert.ToBoolean(dataReader["habi_habilitada"].ToString());
            if (estaHabilitada)
                rbSi.Checked = true;
            else
                rbNo.Checked = true;
        }

        private void frmModificarHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] param = { "@habi_nro", "@habi_hote_codigo", "@habi_piso", "@habi_vista_exterior", "@habi_habilitada", "@habi_descripcion"};
            object[] args = { this.numeroHabitacion, this.codigoHotel, Convert.ToInt32(tbPiso.Text), Convert.ToChar(cbUbicacion.Text), rbSi.Checked, tbDescripcion.Text.ToString() };
            DBConnection.getInstance().executeProcedure("FAAE.modificar_habitacion", param, args);
            MessageBox.Show("Se guardo satisfactoriamente");
            this.Close();
            dataReader.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
