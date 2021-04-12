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
            Numero n2 = new Numero("2,54");

            double numeroDouble = 40;
            string numeroString = "77";

            //string binarioString = "a";

            Console.WriteLine("{0}", Numero.DecimalBinario(numeroDouble));
            Console.WriteLine("{0}\n", Numero.BinarioDecimal(Numero.DecimalBinario(numeroDouble)));

            Console.WriteLine("{0}", Numero.DecimalBinario(numeroString));
            Console.WriteLine("{0}\n", Numero.BinarioDecimal(Numero.DecimalBinario(numeroString)));
          
            /*if(Numero.esBinario(binarioString))
            {
                Console.WriteLine("SI binario");
            }
            else
            {
                Console.WriteLine("NO binario");
            }*/

            Console.ReadKey();
        }
    }
}
