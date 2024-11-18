using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_AreaQuadradoDiagonal_WinForms
{
    internal class Quadrado
    {
        private int n1;
        private int resultado;

        public void setN1(int n1)
        {
            this.n1 = n1;
        }

        public void CalcularArea()
        {
            this.resultado = (n1 * n1)/2;
        }

        public int getArea()
        {
            return this.resultado;
        }
    }
}
