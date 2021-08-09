using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Control_Caldea
{
    public partial class Tiempo : Form
    {
        public Tiempo()
        {
            InitializeComponent();
        }

        private void info_tiempoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.info_tiempoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void Tiempo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.Info_cliente' Puede moverla o quitarla según sea necesario.
            this.info_clienteTableAdapter.Fill(this.caldea.Info_cliente);
            // TODO: esta línea de código carga datos en la tabla 'caldea.info_tiempo' Puede moverla o quitarla según sea necesario.
            this.info_tiempoTableAdapter.Fill(this.caldea.info_tiempo);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Caldea.accdb");

            conexion.Open();

            string consulta = "Insert into Info_cliente(id_tag, fecha, tiempo, area) values("+id_tagTextBox.Text+","
                +fechaDateTimePicker+","+ textBox1 +","+id_areaTextBox.Text+");";

            OleDbCommand comando = new OleDbCommand(consulta, conexion);

        }
    }
}
