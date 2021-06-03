using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo :Auto ,IAFIP
    {
        protected int caballosFuerza;

        public double Precio
        {
            get;
            set;
        }

        public Deportivo(double precio, string patente, int hp)
        {
            base.Precio = precio;
            this.patente = patente;
            this.caballosFuerza = hp;
        }

        public double CalcularImpuesto()
        {
            return (28 * precio) / 100;
        }
    }
}
