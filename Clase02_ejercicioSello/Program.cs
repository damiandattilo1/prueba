using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_ejercicioSello
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse("5");
            ClaseSello.Mensaje = "hola mundo";
            Console.WriteLine(ClaseSello.Imprimir());//retorna string
            ClaseSello.Borrar();
            Console.WriteLine(ClaseSello.Imprimir());//retorna string

            ClaseSello.Mensaje = "hola mundo C#";
            ClaseSello.color = ConsoleColor.Red;
            ClaseSello.ImprimirEnColor();
            Console.WriteLine(ClaseSello.Imprimir());//retorna string

            ClaseSello.Mensaje = "hola mundo";
            ClaseSello.color = ConsoleColor.Red;
            ClaseSello.ImprimirEnColor();
            Console.WriteLine(ClaseSello.Imprimir());
            
            Console.ReadKey();
        }
    }
}
