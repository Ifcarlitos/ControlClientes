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
    public partial class comprobar_descuento : Form
    {
        public comprobar_descuento()
        {
            InitializeComponent();
        }

        private void descuentos_personasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.descuentos_personasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void comprobar_descuento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.descuentos_personas' Puede moverla o quitarla según sea necesario.
            this.descuentos_personasTableAdapter.Fill(this.caldea.descuentos_personas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
