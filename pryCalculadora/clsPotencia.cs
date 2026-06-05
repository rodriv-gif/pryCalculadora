using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class clsPotencia
    {
        public float resultado;

        public void Potencia(float numero1, float numero2)
        {
            resultado = (float)Math.Pow(numero1, numero2);
        }
    }
}
