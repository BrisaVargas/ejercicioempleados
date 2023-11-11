//using Modelos;
//using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Formulario
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
            //NEmpleados.Insert(nom, ape, lega);
        }

       
    }
}
