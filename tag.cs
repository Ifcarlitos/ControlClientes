using System;
using System.Windows.Forms;

namespace Control_Caldea
{
    public partial class tag : Form
    {
        public tag()
        {
            InitializeComponent();
        }

        private void tagBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tagBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.tag' Puede moverla o quitarla según sea necesario.
            this.tagTableAdapter.Fill(this.caldea.tag);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.tagTableAdapter.nuevotag(id_tagTextBox.Text, Convert.ToInt32(id_clienteTextBox.Text));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tagTableAdapter.activartag(false, id_tagTextBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tagTableAdapter.elimtag(id_tagTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tagTableAdapter.activartag(true, id_tagTextBox.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tagTableAdapter.abonado(true, id_tagTextBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tagTableAdapter.abonado(false, id_tagTextBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
