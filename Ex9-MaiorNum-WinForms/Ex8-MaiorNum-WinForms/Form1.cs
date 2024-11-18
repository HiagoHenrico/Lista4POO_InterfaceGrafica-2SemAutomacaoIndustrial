using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8_MaiorNum_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Maior m = new Maior();
            m.setN1(int.Parse(n1.Text));
            m.setN2(int.Parse(n2.Text));
            m.CalcularMaior();
            Resultado.Text = m.getMaior().ToString();
        }
    }
}
