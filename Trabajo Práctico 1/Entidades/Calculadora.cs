using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar (Numero num1, Numero num2, string operador)
        {
            int operadorInt;
            string operadorString;
            char operadorChar;

            operadorString = Calculadora.ValidarOperador(Convert.ToChar(operador));
            operadorChar = Convert.ToChar(operadorString);
            operadorInt = operadorChar;

            if(operadorInt == 43)
            {
                return num1 + num2;
            }
            else if(operadorInt == 45)
            {
                return num1 - num2;
            }
            else if(operadorInt == 47)
            {
                return num1 / num2;
            }
            else if (operadorInt == 42)
            {
                return num1 * num2;
            }
            else
            {
                return 5;
            }

        }
        
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return Char.ToString(operador);
            }
            else
            {
                return Char.ToString('+');
            }
        }
       
    }
}
