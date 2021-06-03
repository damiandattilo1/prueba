using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Auto : Vehiculo
    {
        protected string patente;

        public Auto(double precio, string patente)
        {
            base.precio = precio;
            this.patente = patente;
        }

        public void MostrarPatente()
        {
            Console.WriteLine("La patente es: {0}", patente);
        }
    }
}
