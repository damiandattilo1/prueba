using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControlSeguridad <T> where T: class
    {
        public int capacidadMaxima;
        public List<T> lista;

        public ControlSeguridad(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.lista = new List<T>();
        }

        public bool Agregar(T aprobado)
        {
            return (this + aprobado);
        }
        public static bool operator +(ControlSeguridad<T> control, T aprobado)
        {
            bool flag = false;
            /*bool esRepetido = false;

            foreach(AireAcondicionado item in control.lista)
            {
                if(item == (AireAcondicionado)aprobado)
                {
                    esRepetido = true;
                }
            }*/
            if (control.lista.Count < control.capacidadMaxima)// && esRepetido == false)
            {
                control.lista.Add(aprobado);
                flag = true;
            }
            /*else if (esRepetido == true)
            {
                Console.WriteLine("El producto ya se encuentra en la lista!!!\n");
            }*/
            else
            {
                Console.WriteLine("Deposito completo!!!\n");
            }
            return flag;
        }
        public bool Remover(T aprobado)
        {
            return (this - aprobado);
        }
        public static bool operator -(ControlSeguridad<T> control, T aprobado)
        {
            bool retorno = false;
            int i = control.GetIndice(aprobado);

            if (i != -1)
            {
                foreach (T item in control.lista)
                {
                    if (i == 0)
                    {
                        control.lista.Remove(item);
                        retorno = true;
                        break;
                    }
                    i--;
                }
            }
            return retorno;
        }



        public int GetIndice(T aprobado)
        {
            int retorno = -1;
            int i = 0;

            foreach (T item in this.lista)
            {
                if (item == aprobado)
                {
                    break;
                }
                i++;
            }
            if (i != this.capacidadMaxima - 1)
            {
                retorno = i;
            }
            return retorno;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad Maxima = {this.capacidadMaxima}\n\nListado de productos aprobados:\n");

            foreach (T item in lista)
            {
                sb.AppendLine($"{item.ToString()}");
            }

            return sb.ToString();
        }

        public static implicit operator string (ControlSeguridad<T> control)
        {
            return control.ToString();
        }
    }
}
