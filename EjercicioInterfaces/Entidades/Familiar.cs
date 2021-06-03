using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar:Auto
    {
        protected int cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos)
        {
            this.precio = precio;
            this.patente = patente;
            this.cantAsientos = cantidadAsientos;
        }
    }
}
