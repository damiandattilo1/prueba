using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int id;
        protected EficienciaEnergetica eficiencia;

        public Producto (int id,  EficienciaEnergetica eficiencia)
        {
            this.id = id;
            this.eficiencia = eficiencia;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public EficienciaEnergetica Eficiencia
        {
            get
            {
                return this.eficiencia;
            }
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.Id == p2.Id);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Eficiencia energetica: {this.Eficiencia}");
            return sb.ToString();
        }

        
    }

}
