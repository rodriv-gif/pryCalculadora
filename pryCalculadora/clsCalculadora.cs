using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class clsCalculadora
    {
        //Atributos de entrada
        private float numero1;
        private float numero2;
        //Atributos pero es de salida
        private float resultado;

        //uso de propiedades set y get
        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        //usar el constructor 
        /*public clsCalculadora(float n1, float n2)
        {
            this.numero1 = n1;
            this.numero2 = n2;
        }
        */
        

        //funciones o métodos
        public float Sumar()
        {
            resultado = numero1 + numero2;
            return resultado;
        }

        public float Restar()
        {
            resultado = numero1 - numero2;
            return resultado;
        }

    }
}
