using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class Derivada
    {
        public float numero1;
        public float numero2;

        public float Resultado;

        public float CalcularDerivada()
        {
            Resultado = numero1 * numero2;

            return Resultado;

        }

    }
}
