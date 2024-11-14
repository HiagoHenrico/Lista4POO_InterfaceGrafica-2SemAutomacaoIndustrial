using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista4POO_InterfaceGrafica_hiago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaRetangulo ar;
            ar = new AreaRetangulo();

            ar.setN1(int.Parse(n1.Text));
            ar.setN2(int.Parse(n2.Text));
            ar.CalcularArea();
            Resultado.Text = ar.getArea().ToString();
            
        }
    }
}
