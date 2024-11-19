using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11_PesoIdeal_WinForms
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
            Peso p = new Peso();
            p.setN1(double.Parse(n1.Text));
            p.setN2(double.Parse(n2.Text));
            p.CalcularPesoIdeal();
            result.Text = p.getPeso().ToString();
        }
    }
}
