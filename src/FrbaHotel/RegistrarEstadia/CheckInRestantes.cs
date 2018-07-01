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
    public partial class CheckInRestantes : Form
    {

        string docTipo = DBConnection.getInstance().getUsuario().getDocTipo().ToString();
        string docNro = DBConnection.getInstance().getUsuario().getDocNro().ToString();
        string mail = DBConnection.getInstance().getUsuario().getMail().ToString();

        public CheckInRestantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBConnection.getInstance().conexionCorrecta())
            {
                if (textBox1.Text.ToString().Length > 0 && comboBox1.Text.ToString().Length > 0 && textBox2.Text.ToString().Length > 0 && textBox3.Text.ToString().Length > 0 && espaciosEnLaReserva(textBox1.Text.ToString()))
                {
                    //CheckIn checkIn = new CheckIn(textBox1.Text.ToString(), comboBox1.Text.ToString(), Convert.ToInt32(textBox2.Text), textBox3.Text.ToString(), docTipo, Convert.ToInt32(docNro), mail);
                    //checkIn.guardar();
                    MessageBox.Show("Check-in realizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Realizar el Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private bool espaciosEnLaReserva(string reseCodigo)
        {
            try
            {
                Boolean quedanEspacios;
                SqlDataReader dataReader = DBConnection.getInstance().executeQuery("select * from FAAE.Reserva_Habitacion join FAAE.Habitacion on habi_nro = reha_habi_nro and habi_hote_codigo = reha_hote_codigo join FAAE.Tipo on habi_tipo_codigo = tipo_codigo	where " + reseCodigo + " = reha_rese_codigo and tipo_cant_personas < (select count(*) from FAAE.Estadia where esta_habi_nro = reha_habi_nro and esta_hote_codigo = reha_hote_codigo and esta_rese_codigo = @reseCodigo)");
                quedanEspacios = dataReader.Read();
                dataReader.Close();
                return quedanEspacios;
            }
            catch (Exception)
            {
                MessageBox.Show("Reserva sin efecto, realizar una nueva reserva"); return false;
            }
        }
    }
}
