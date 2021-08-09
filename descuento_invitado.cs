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
    public partial class descuento_invitado : Form
    {
        public descuento_invitado()
        {
            InitializeComponent();
        }

        private void invitadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invitadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void descuento_invitado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.descuentos_personas' Puede moverla o quitarla según sea necesario.
            this.descuentos_personasTableAdapter.Fill(this.caldea.descuentos_personas);
            // TODO: esta línea de código carga datos en la tabla 'caldea.invitado' Puede moverla o quitarla según sea necesario.
            this.invitadoTableAdapter.Fill(this.caldea.invitado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Caldea.accdb");

            conexion.Open();

            string consulta = "select [nombre invitado] from invitado " +
                "where [nombre invitado] = '" + nombre_invitadoTextBox.Text + "';";

            OleDbCommand comando = new OleDbCommand(consulta, conexion);

            OleDbDataReader lector;

            lector = comando.ExecuteReader();

            Boolean existe = lector.HasRows;

            if (existe)
            {
                Form correcto = new Correcto();
                correcto.Show();

                this.descuentos_personasTableAdapter.nuevodescuento("no", nombre_invitadoTextBox.Text, 50);

            }
            else
            {
                Form mal = new no_descuento();
                mal.Show();
            }
        }
    }
}
