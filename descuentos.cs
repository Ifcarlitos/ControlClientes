using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Caldea
{
    public partial class descuentos : Form
    {
        public descuentos()
        {
            InitializeComponent();
        }

        private void invitadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invitadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void descuentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.invitado' Puede moverla o quitarla según sea necesario.
            this.invitadoTableAdapter.Fill(this.caldea.invitado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form desc = new descuento_cliente();
            desc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form desi = new descuento_invitado();
            desi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form comprobar = new comprobar_descuento();
            comprobar.Show();
        }
    }
}
