using Modelos;
using Negocio;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Empleado> lista =new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string ape= textBox2.Text;
            int lega=int.Parse(textBox3.Text);
            NEmpleados.Insert(nom,ape,lega);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            lista = NEmpleados.Get();
            nEmpleadosBindingSource.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            textBox1.Text = string.Empty; label4.Text = string.Empty; textBox2.Text = string.Empty; textBox3.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = NEmpleados.Get();
            nEmpleadosBindingSource.DataSource = lista;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
            textBox1.Text = string.Empty; label4.Text = string.Empty; textBox2.Text = string.Empty; textBox3.Text = string.Empty;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var selected = (Empleado)nEmpleadosBindingSource.Current;
                if (selected != null)
                {
                    textBox1.Text = selected.nombre.ToString();
                    textBox2.Text = selected.apellido.ToString();
                    textBox3.Text = selected.legajo.ToString();
                    label4.Text = $"{selected.id.ToString()}";
                }
                else { textBox1.Text = string.Empty; label4.Text = string.Empty; textBox2.Text = string.Empty; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                NEmpleados.Delete(int.Parse(label4.Text));
                lista = NEmpleados.Get();
                nEmpleadosBindingSource.DataSource = lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                string nom = textBox1.Text;
                string ape = textBox2.Text;
                int lega = int.Parse(textBox3.Text);
                int id = int.Parse(label4.Text);
            NEmpleados.Update(id,nom, ape, lega);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
            lista = NEmpleados.Get();
            nEmpleadosBindingSource.DataSource = lista;
        }
    }
}