using System;
using System.Windows.Forms;

namespace Control_Caldea
{
    public partial class InicioMenu : Form
    {
        public InicioMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Fcliente = new Clientes();
            Fcliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Frelacion = new relacion();
            Frelacion.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Ftag = new tag();
            Ftag.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Flector = new Comprobar_relación();
            Flector.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form abo = new abonado_invitado();
            abo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form desco = new descuentos();
            desco.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form test = new test();
            test.Show();
        }
    }
}
