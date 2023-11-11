using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string ape = textBox2.Text;
            int lega = int.Parse(textBox3.Text);
            NEmpleados.Insert(nom, ape, lega);

        }
    }
}