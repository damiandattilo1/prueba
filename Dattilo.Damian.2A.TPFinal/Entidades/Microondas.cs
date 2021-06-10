using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Microondas : Producto, IConsumo
    {
        protected ETamanio tamanio;

        public Microondas(int id, EficienciaEnergetica eficiencia, ETamanio tamanio) : base(id, eficiencia)
        {
            this.tamanio = tamanio;
        }

        public ETamanio Tamanio
        {
            get
            {

                return this.tamanio;
            }
        }



        public static bool operator ==(Microondas m1, Microondas m2)
        {
            return (m1.Tamanio == m2.Tamanio);
        }

        public static bool operator !=(Microondas m1, Microondas m2)
        {
            return !(m1 == m2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}");
            sb.AppendLine($"Tamanio: {this.Tamanio}");
            if (this.esEficiente())
            {
                sb.AppendLine("El producto esta aprobado");
            }
            else
            {
                sb.AppendLine("El producto necesita ser revisado");
            }

            return sb.ToString();
        }

        public bool esEficiente()
        {
            bool retorno = false;

            if (this.Eficiencia == EficienciaEnergetica.A || this.Eficiencia == EficienciaEnergetica.B)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
