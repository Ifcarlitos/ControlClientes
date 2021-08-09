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
    public partial class descuento_cliente : Form
    {
        public descuento_cliente()
        {
            InitializeComponent();
        }

        private void tagBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tagBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void descuento_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.descuentos_personas' Puede moverla o quitarla según sea necesario.
            this.descuentos_personasTableAdapter.Fill(this.caldea.descuentos_personas);
            // TODO: esta línea de código carga datos en la tabla 'caldea.tag' Puede moverla o quitarla según sea necesario.
            this.tagTableAdapter.Fill(this.caldea.tag);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Caldea.accdb");

            conexion.Open();

            string consulta = "select id_tag from tag " +
                "where id_tag= '" + id_tagTextBox.Text + "' and abonado =" + true + ";";

            OleDbCommand comando = new OleDbCommand(consulta, conexion);

            OleDbDataReader lector;

            lector = comando.ExecuteReader();

            Boolean existe = lector.HasRows;


            if (existe)
            {
                Form nodesc = new no_descuento();
                nodesc.Show();
            }
            else
            {

                string consulta2 = "SELECT COUNT(id_tag) FROM lectura where id_tag ='" +id_tagTextBox.Text +
                    "' and  YEAR([fecha entrada]) =2020 HAVING COUNT(id_tag)=2;";
                OleDbCommand comando2 = new OleDbCommand(consulta2, conexion);

                OleDbDataReader lecto2;
                lecto2 = comando2.ExecuteReader();
                Boolean existe2 = lecto2.HasRows;

                if (existe2)
                {
                    Form corr = new Correcto();
                    corr.Show();
                    this.descuentos_personasTableAdapter.nuevodescuento(id_tagTextBox.Text, "no", 20);
                }
                else
                {
                    Form nodesc = new no_descuento();
                    nodesc.Show();
                }     

            }
            conexion.Close();
        }
    }
}
