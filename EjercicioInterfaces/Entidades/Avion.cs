using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo , IAFIP
    {
        protected double velocidadMaxima;

        public double Precio
        {
            get
            {
                return base.precio;
            }
            set
            {
                base.precio = value;
            }
        }

        public Avion(double precio, double velMax)
        {
            base.Precio = precio;
            this.velocidadMaxima = velMax;
        }

        public double CalcularImpuesto()
        {
            return (33 * precio) / 100;
        }
    }
}
