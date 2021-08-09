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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.invitado' Puede moverla o quitarla según sea necesario.
            this.invitadoTableAdapter.Fill(this.caldea.invitado);
            // TODO: esta línea de código carga datos en la tabla 'caldea.Relación' Puede moverla o quitarla según sea necesario.
            this.relaciónTableAdapter.Fill(this.caldea.Relación);
            // TODO: esta línea de código carga datos en la tabla 'caldea.tag' Puede moverla o quitarla según sea necesario.
            this.tagTableAdapter.Fill(this.caldea.tag);
            // TODO: esta línea de código carga datos en la tabla 'caldea.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.caldea.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pruebaN = "Carla";
            string pruebaA = "vilaro";
            string pruebaNaci ="españa";
            string pruebaE = "email@email.com";
            string pruebaT = "654784789";

            for (int i = 0; i < 1000; i++) {

                this.clienteTableAdapter.nuevocliente(pruebaN, pruebaA,pruebaNaci,pruebaE,pruebaT);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pruebaTAG = "T456";
            string pruebArea = "Aquamasaje";
            for (int i=0; i < 100; i++)
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Caldea.accdb");

                conexion.Open();

                string consulta = "select id_tag,id_area from Relación " +
                    "where id_tag= '" + pruebaTAG + "' and id_area= '" + pruebArea +
                    "';";

                OleDbCommand comando = new OleDbCommand(consulta, conexion);

                OleDbDataReader lector;

                lector = comando.ExecuteReader();

                Boolean existe = lector.HasRows;

                if (existe)
                {
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

        private void button3_Click(object sender, EventArgs e)
        {
            string tag = "B456";
            Boolean activar;

            for(int i = 0; i < 100; i++)
            {
                activar = true;

                this.tagTableAdapter.activartag(activar, tag);

                activar = false;

                this.tagTableAdapter.activartag(activar, tag);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string tag = "B456";
            string area = "Aquamasaje";

            for(int i =0; i < 100; i++)
            {

                this.relaciónTableAdapter.nuevarela(tag, area);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tag = "B456";
            int cliente = 11;
            string nombreC = "Carlota";

            for (int i = 0; i < 1000; i++)
            {
                this.invitadoTableAdapter.nuevoinvi(tag, cliente, nombreC);
            }
        }
    }
}
