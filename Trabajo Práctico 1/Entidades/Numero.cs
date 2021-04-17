using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set
            {
                this.numero = Numero.ValidarNumero(value);
            }
        }

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero (string strNumero)
        {
            this.SetNumero = strNumero;
        }
        
        public static int BinarioDecimal(string binario)
        {
            int j = 1;
            int resultado = 0;
            for(int i = binario.Length - 1; i>=0; i--)
            {
                //Console.WriteLine("{0}", j);
                if( (binario[i]) == '1')
                {
                    resultado = resultado + j;
                }
                j = j * 2;
            }
            //Console.WriteLine("{0}", j);
            return resultado;
        }

        public static string DecimalBinario(double numero)
        {
            string resultado = "00";
            string res = "00";
            int numeroInt = (int)numero;
            if(numeroInt == 0)
            {
                return "0";
            }
            else if (numeroInt == 1)
            {
                return "1";
            }
            else
            { 
                if (numeroInt % 2 == 1)
                {
                    resultado = string.Format("{0}", '1');
                }
                else if (numeroInt % 2 == 0)
                {
                    resultado = string.Format("{0}", '0');
                }
                numeroInt = numeroInt / 2;
                while (numeroInt != 1)
                {
                    // Console.WriteLine("{0}", numero % 2);
                    if (numeroInt % 2 == 1)
                    {
                        resultado = string.Format("{0}{1}", resultado, '1');
                    }
                    else if (numeroInt % 2 == 0)
                    {
                        resultado = string.Format("{0}{1}", resultado, '0');
                    }
                    numeroInt = numeroInt / 2;
                }

                resultado = string.Format("{0}{1}", resultado, '1');
                res = string.Format("{0}", resultado[resultado.Length - 1]);
                for (int i = resultado.Length - 2; i >= 0; i--)
                {
                    res = string.Format("{0}{1}", res, resultado[i]);
                }
            }
            return res;
        }
        
        public static string DecimalBinario (string numero)
        {
            double numeroDouble = Convert.ToDouble(numero);
            return Numero.DecimalBinario(numeroDouble);
        }
        
        private static bool esBinario(string binario)
        {
            int esBinario = 1;
            
            for (int i = 0; i<binario.Length; i++)
            {
                
                if (binario[i] != '0' && binario[i] != '1')
                {
                    esBinario = 0;
                    break;
                }
            }
        
            if(esBinario == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double operator + (Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero*n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        
        private static double ValidarNumero(string strNumero)
        {
            double numero;
            if(!double.TryParse(strNumero, out numero))
            {
                return 0;
            }
            else
            {
                return numero;
            }
        }
    }

}
