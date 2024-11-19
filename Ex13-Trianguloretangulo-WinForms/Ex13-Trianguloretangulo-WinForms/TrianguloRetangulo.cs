using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Trianguloretangulo_WinForms
{
    internal class TrianguloRetangulo
    {
        private double A;
        private double B;
        private double C;

        public void SetLadoA(double A)
        {
            this.A = A;
        }

        public void SetLadoB(double B)
        {
            this.B = B;
        }

        public void SetLadoC(double C)
        {
            this.C = C;
        }

        public bool EhTrianguloRetangulo()
        {
            double[] lados = { A, B, C };
            Array.Sort(lados);

            double hipotenusa = lados[2];
            double cateto1 = lados[0];
            double cateto2 = lados[1];

            return Math.Pow(hipotenusa, 2) == Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
        }
    }
}
