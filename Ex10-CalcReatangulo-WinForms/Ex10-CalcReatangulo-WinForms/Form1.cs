﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10_CalcReatangulo_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Reatangulo a = new Reatangulo();
            a.setN1(int.Parse(n1.Text));
            a.setN2(int.Parse(n2.Text));
            a.CalcularArea();
            Resultado.Text = a.TamanhoTerreno().ToString();
        }
    }
}
