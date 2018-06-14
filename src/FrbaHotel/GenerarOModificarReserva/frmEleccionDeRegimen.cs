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
        string regimenQueEligio;
        public frmEleccionDeRegimen(string codHotel)
        {
            InitializeComponent();
            this.codHotel = codHotel;
            this.lvRegimenes.Items.Clear();
            SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT reho_regi_codigo FROM FAAE.Regimen_Hotel WHERE reho_hote_codigo = " + codHotel);

            while (dataReader.Read())
            {
                ListViewItem listItem = this.nuevoItem(dataReader);
                this.lvRegimenes.Items.Add(listItem);
            }
            dataReader.Close();
        }

        public ListViewItem nuevoItem(SqlDataReader dataReader)
        {
            ListViewItem listItems = new ListViewItem(dataReader["reho_regi_codigo"].ToString());
            return listItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regimenQueEligio = this.lvRegimenes.SelectedItems[0].Text.ToString();
            Close();
        }

        public string regimenElegido()
        {
            return regimenQueEligio;
        }
    }
}
