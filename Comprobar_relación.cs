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
    public partial class Comprobar_relación : Form
    {
        public Comprobar_relación()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void relaciónBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.relaciónBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.Relación' Puede moverla o quitarla según sea necesario.
            this.relaciónTableAdapter.Fill(this.caldea.Relación);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Caldea.accdb");

            conexion.Open();

            string consulta = "select id_tag,id_area from Relación " +
                "where id_tag= '" + id_tagTextBox.Text + "' and id_area= '" + id_areaTextBox.Text +
                "';";

            OleDbCommand comando = new OleDbCommand(consulta, conexion);

            OleDbDataReader lector;

            lector = comando.ExecuteReader();

            Boolean existe = lector.HasRows;

            if(existe){
                Form correcto = new estado();
                correcto.Show();
            }
            else
            {
                Form mal = new Mal();
                mal.Show();
            }

        }
    }
}
