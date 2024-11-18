using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_AreaTriangulo_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Triangulo t = new Triangulo();
            t.setN1(int.Parse(n1.Text));
            t.setN2(int.Parse(n2.Text));
            t.CalcularArea();
            Resultado.Text = t.getArea().ToString();

        }
    }
}
