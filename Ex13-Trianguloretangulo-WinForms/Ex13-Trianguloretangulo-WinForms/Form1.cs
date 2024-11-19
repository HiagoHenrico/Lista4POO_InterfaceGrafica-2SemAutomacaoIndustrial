using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13_Trianguloretangulo_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            TrianguloRetangulo t = new TrianguloRetangulo();
            t.SetLadoA(double.Parse(A.Text));
            t.SetLadoB(double.Parse(B.Text));
            t.SetLadoC(double.Parse(C.Text));
            label4.Text = t.EhTrianguloRetangulo().ToString();
        }
    }
}
