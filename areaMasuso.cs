using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Caldea
{
    public partial class areaMasuso : Form
    {
        public areaMasuso()
        {
            InitializeComponent();
        }

        private void lecturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.caldea);

        }

        private void areaMasuso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'caldea.lectura' Puede moverla o quitarla según sea necesario.
            this.lecturaTableAdapter.Fill(this.caldea.lectura);

        }

        private void fecha_entradaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fecha_entradaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.lecturaTableAdapter.buscar_area(fecha_entradaDateTimePicker1.Value, fecha_entradaDateTimePicker.Value);

        }
    }
}
