using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_MilhaMarQuilometro_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Milha m = new Milha();
            m.setN1(int.Parse(n1.Text));
            m.CalcularDistancia();
            Resultado.Text = m.getDistancia().ToString();
        }
    }
}
