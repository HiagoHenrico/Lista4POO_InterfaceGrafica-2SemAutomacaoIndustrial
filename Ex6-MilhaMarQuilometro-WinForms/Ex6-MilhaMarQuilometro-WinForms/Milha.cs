using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_MilhaMarQuilometro_WinForms
{
    internal class Milha
    {
        private float n1;
        private float resultado;

        public void setN1(float n1)
        {
            this.n1 = n1;
        }

        public void CalcularDistancia()
        {
            this.resultado = (n1 * 1852) / 1000;
        }

        public float getDistancia()
        {
            return this.resultado;
        }

    }
}
