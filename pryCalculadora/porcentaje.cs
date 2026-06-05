using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class porcentaje
    {
        private float numero1;
        private float numero2;

        private float resultado;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }


        public float Porcentaje()
        {
            resultado = numero1 + numero2; 
            return resultado;
        } 
    }
}
