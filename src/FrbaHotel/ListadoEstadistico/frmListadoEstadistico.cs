using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ListadoEstadistico {
    public partial class frmListadoEstadistico : Form {

        public frmListadoEstadistico() {
            InitializeComponent();
            this.setCbProperties();
        }

        public void setCbProperties() {
            this.cbConsulta.Items.Add("Hoteles con mayor cantidad de reservas canceladas");
            this.cbConsulta.Items.Add("Hoteles con mayor cantidad de consumibles facturados");
            this.cbConsulta.Items.Add("Hoteles con mayor cantidad de días fuera de servicio");
            this.cbConsulta.Items.Add("Habitaciones con mayor cantidad de días y veces que fueron ocupadas");
            this.cbConsulta.Items.Add("Clientes con mayor cantidad de puntos");
            this.cbTrimestre.Items.Add("ENE-MAR");
            this.cbTrimestre.Items.Add("ABR-JUN");
            this.cbTrimestre.Items.Add("JUL-SEP");
            this.cbTrimestre.Items.Add("OCT-DIC");
            Enumerable.Range(1990, DateTime.Now.Year - 1989).ToList().ForEach(anio => this.cbAnio.Items.Add(anio));
        }

        public void setLvPropertiesHotel() {
            this.lvListadoEstadistico.Columns.Add("Nombre");
            this.lvListadoEstadistico.Columns.Add("Estrellas");
            this.lvListadoEstadistico.Columns.Add("Direccion_Calle");
            this.lvListadoEstadistico.Columns.Add("Direccion_Nro");
            this.lvListadoEstadistico.Columns.Add("Ciudad");
            this.lvListadoEstadistico.Columns.Add("Pais");
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        public void setLvPropertiesHabitacion() {
            this.lvListadoEstadistico.Columns.Add("Numero");
            this.lvListadoEstadistico.Columns.Add("Tipo");
            this.lvListadoEstadistico.Columns.Add("Hotel");
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        public void setLvPropertiesCliente() {
            this.lvListadoEstadistico.Columns.Add("Nombre");
            this.lvListadoEstadistico.Columns.Add("Apellido");
            this.lvListadoEstadistico.Columns.Add("Puntos");
            this.lvListadoEstadistico.View = View.Details;
            this.lvListadoEstadistico.MultiSelect = false;
        }

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e) {
            lvListadoEstadistico.Clear();
            string seleccion = cbConsulta.Text.ToString();
            if (seleccion.Split(' ').First().Equals("Hoteles"))
                this.setLvPropertiesHotel();

            if (seleccion.Split(' ').First().Equals("Habitaciones"))
                this.setLvPropertiesHabitacion();

            if (seleccion.Split(' ').First().Equals("Clientes"))
                this.setLvPropertiesCliente();
        }
    }
}
