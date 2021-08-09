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
    public partial class abonado_invitado : Form
    {
        public abonado_invitado()
        {
            InitializeComponent();
        }

        private void tagBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tagBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void abonado_invitado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.tag' Puede moverla o quitarla según sea necesario.
            this.tagTableAdapter.Fill(this.caldea.tag);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Caldea.accdb");

            conexion.Open();

            string consulta2 = "select id_tag from tag " +
                "where id_tag= '" + id_tagTextBox.Text + "' and abonado =" + true + ";";

            OleDbCommand comando2 = new OleDbCommand(consulta2, conexion);

            OleDbDataReader lector2;

            lector2 = comando2.ExecuteReader();

            Boolean existe2 = lector2.HasRows;

            
            if (existe2)
            {
                Form invi = new invitados();
                invi.Show();
            }
            else
            {
                Form mal = new Mal();
                mal.Show();
            }
            conexion.Close();
        }
    }
}
