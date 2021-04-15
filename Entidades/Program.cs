using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero(5);
            Numero n2 = new Numero(2);

            string operador = Char.ToString('+');

            double resultado;

            resultado = Calculadora.Operar(n1, n2, operador);

            Console.WriteLine("El resultado es: {0}", resultado);

            Console.ReadKey();
        }
    }
}
