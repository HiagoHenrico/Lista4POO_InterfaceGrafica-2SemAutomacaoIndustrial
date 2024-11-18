using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_ConversaoDolar_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Cotacao c = new Cotacao();
            c.setN1(float.Parse(n1.Text));
            c.setN2(float.Parse(n2.Text));
            c.CalcularCotacao();
            Resultado.Text = c.getCotacao().ToString();
        }
             
    }
}
    
