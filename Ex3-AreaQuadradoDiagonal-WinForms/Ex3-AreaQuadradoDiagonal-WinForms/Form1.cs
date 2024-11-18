using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_AreaQuadradoDiagonal_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Quadrado q = new Quadrado();
            q.setN1(int.Parse(n1.Text));
            q.CalcularArea();
            Resultado.Text = q.getArea().ToString();
        }
    }
}
