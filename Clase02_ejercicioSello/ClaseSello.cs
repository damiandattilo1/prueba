using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_ejercicioSello
{
    class ClaseSello
    {
        public static string Mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return ClaseSello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
              ClaseSello.Mensaje ="";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = ClaseSello.color;
            Console.WriteLine(ClaseSello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string ArmarFormatoMensaje()
        {
            string AuxString;
            int StrLength = ClaseSello.Mensaje.Length;
            if(StrLength>0)
            {
                AuxString = new string('*', StrLength + 2) + "\n";
                AuxString += "*" + ClaseSello.Mensaje + "*" + "\n";
                AuxString += new string('*', StrLength + 2);
                return AuxString;
            }
            return string.Empty;
        }
    }
}
