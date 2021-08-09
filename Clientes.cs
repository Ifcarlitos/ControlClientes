using System;
using System.Windows.Forms;

namespace Control_Caldea
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.caldea.cliente);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.editarcliente(nombreTextBox.Text, apellidosTextBox.Text,
                nacionalidadTextBox.Text, emailTextBox.Text, telefonoTextBox.Text, Convert.ToInt32(id_clienteTextBox.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.nuevocliente(nombreTextBox.Text, apellidosTextBox.Text,
                nacionalidadTextBox.Text, emailTextBox.Text, telefonoTextBox.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Elimcliente(nombreTextBox.Text);

            nombreTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.buscar(this.caldea.cliente, nombreTextBox.Text);

        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
