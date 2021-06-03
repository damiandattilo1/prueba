using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected double precio;

        public Vehiculo(double precio)
        {
            this.precio = precio;
        }

        public void MostrarPrecio()
        {
            Console.WriteLine("El precio es: {0}", precio);
        }
    }
}
