using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Privado:Avion
    {
        protected int valoracionServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion)
        {
            this.precio = precio;
            this.velocidadMaxima = velocidad;
            this.valoracionServicioDeAbordo = valoracion;
        }
    }
}
