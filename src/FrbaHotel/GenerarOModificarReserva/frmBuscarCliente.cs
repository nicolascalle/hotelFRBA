using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarOModificarReserva
{
    public partial class frmBuscarCliente : Form
    {
        SqlDataReader dataReader;
        public frmBuscarCliente()
        {
            InitializeComponent();
            this.setDocTipoOptions();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.camposIncompletos())
            {
                MessageBox.Show("Complete alguna de las 2 opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.camposCompletos())
            {
                MessageBox.Show("Complete solo UNA de las 2 opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbMail.Text.Length != 0)
                {
                    frmMostrarCliente ventanaCliente = new frmMostrarCliente(this.buscarPorMail());
                    ventanaCliente.ShowDialog();
                }
                else
                {
                    frmMostrarCliente ventanaCliente = new frmMostrarCliente(this.buscarPorDocumento());
                    ventanaCliente.ShowDialog();
                }
            }
                
        }

        private string buscarPorDocumento()
        {
            string query = "SELECT clie_nombre, clie_apellido FROM FAAE.Cliente WHERE clie_doc_tipo LIKE '" + cbDocTipo.Text.ToString() + "' AND clie_doc_nro = " + tbDocNro.Text.ToString();
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            string nombre = dataReader["clie_nombre"].ToString();
            string apellido = dataReader["clie_apellido"].ToString();
            dataReader.Close();
            return nombre + " " + apellido;
        }

        private string buscarPorMail()
        {
            string query = "SELECT clie_nombre, clie_apellido FROM FAAE.Cliente WHERE clie_mail LIKE '" + tbMail.Text.ToString() + "'";
            dataReader = DBConnection.getInstance().executeQuery(query);
            dataReader.Read();
            string nombre = dataReader["clie_nombre"].ToString();
            string apellido = dataReader["clie_apellido"].ToString();
            dataReader.Close();
            return nombre + " " + apellido;
        }

        private void setDocTipoOptions()
        {
            new List<string>() { "Pasaporte", "DNI", "LE" }.ForEach(docTipo => cbDocTipo.Items.Add(docTipo));
            cbDocTipo.SelectedItem = "Pasaporte";
        }

        public bool camposIncompletos()
        {
            return new List<Control> { tbDocNro, tbMail }.All(form => form.Text.Length == 0);
        }
        public bool camposCompletos()
        {
            return new List<Control> { tbDocNro, tbMail }.All(form => form.Text.Length != 0);
        }
    }
}
