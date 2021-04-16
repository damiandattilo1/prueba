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
            Numero n1 = new Numero("7,89");
            Numero n2 = new Numero("8");

            // string operador = Char.ToString('/');
            string operador = ("-");

            double resultado;

            resultado = Calculadora.Operar(n1, n2, operador);

            Console.WriteLine("El resultado es: {0}", resultado);
            //resultado = Numero.ValidarNumero("/");

            //Console.WriteLine("La conversion es: {0}", resultado);


            Console.ReadKey();
        }
    }
}
