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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class frmRegistrarEstadia : Form
    {
        string docTipo = DBConnection.getInstance().getUsuario().getDocTipo().ToString();
        string docNro = DBConnection.getInstance().getUsuario().getDocNro().ToString();
        string mail = DBConnection.getInstance().getUsuario().getMail().ToString();
        
        public frmRegistrarEstadia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBConnection.getInstance().conexionCorrecta())
            {
                if (textBox1.Text.ToString().Length > 0)
                {
                    DBConnection.getInstance().executeQuery("UPDATE FAAE.Estadia set esta_fecha_salida = getdate(), esta_usuaOut_doc_tipo = '" + docTipo + "', esta_usuaOut_doc_nro = " + Convert.ToInt32(docNro) + ", esta_usuaOut_mail = '" + mail + "' WHERE esta_rese_codigo =" + Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Check-out realizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Realizar el Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DBConnection.getInstance().conexionCorrecta())
            {
                if (textBox1.Text.ToString().Length > 0 && estadiaConEfecto())
                {
                    DBConnection.getInstance().executeQuery(
                        "insert FAAE.Estadia(esta_clie_doc_tipo, esta_clie_doc_nro, esta_clie_mail, esta_habi_nro, esta_hote_codigo, esta_rese_codigo, esta_usuaIn_doc_tipo, esta_usuaIn_doc_nro, esta_usuaIn_mail) select top 1 rese_clie_doc_tipo, rese_clie_doc_nro, rese_clie_mail, reha_habi_nro, reha_hote_codigo, rese_codigo, '" + docTipo + "', " + Convert.ToInt32(docNro) + ", '" + mail + "' from FAAE.Reserva join FAAE.Reserva_Habitacion on reha_rese_codigo = rese_codigo where rese_codigo = " + textBox1.Text.ToString());
                    MessageBox.Show("Check-in realizado correctamente");
                    this.Close();
                    CheckInRestantes CheckInRestantes = new CheckInRestantes();
                    CheckInRestantes.Show();
                }
                else
                {
                    MessageBox.Show("Error al Realizar el Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool estadiaConEfecto()
        {
            try
            {
                Boolean estadiaConEfecto;
                SqlDataReader dataReader = DBConnection.getInstance().executeQuery("SELECT rese_codigo AS 'date' FROM FAAE.Reserva WHERE rese_fecha_inicio = getdate() and rese_codigo = " + textBox1.Text.ToString() + "group by rese_codigo");
                estadiaConEfecto = dataReader.Read();
                dataReader.Close();
                return estadiaConEfecto;
            }
            catch (Exception)
            {
                MessageBox.Show("Reserva sin efecto, realizar una nueva reserva"); return false;
            }
        }
    }
}
