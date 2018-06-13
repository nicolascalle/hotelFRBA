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

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmEleccionDeRegimen : Form
    {
        string codHotel;
        public frmEleccionDeRegimen(string codHotel)
        {
            InitializeComponent();
            this.codHotel = codHotel;
        }

        private void frmEleccionDeRegimen_Load(object sender, EventArgs e)
        {
            string query = "SELECT reho_regi_codigo FROM FAAE.Regimen_Hotel WHERE reho_hote_codigo = " + this.codHotel;
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery(query);   
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            dgvRegimenesDisponibles.DataSource = dt;
            dataReader.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.regimen_HotelTableAdapter.FillBy(this.gD1C2018DataSet.Regimen_Hotel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
