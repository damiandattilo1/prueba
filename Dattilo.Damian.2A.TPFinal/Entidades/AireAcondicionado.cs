using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AireAcondicionado : Producto, IConsumo
    {
        protected ETipo tipo;

        public AireAcondicionado(int id, EficienciaEnergetica eficiencia, ETipo tipo) : base(id, eficiencia)
        {
            this.tipo = tipo;
            //this.Eficiencia = eficiencia;
        }
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        /*public EficienciaEnergetica Eficiencia
        {
            get
            {

            }
            set
            {

            }
        }*/

        public static bool operator ==(AireAcondicionado ac1, AireAcondicionado ac2)
        {
            return (ac1.Tipo == ac2.Tipo);
        }

        public static bool operator !=(AireAcondicionado ac1, AireAcondicionado ac2)
        {
            return !(ac1 == ac2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}");
            sb.AppendLine($"Tamanio: {this.Tipo}");
            if(this.esEficiente())
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

            if(this.Eficiencia == EficienciaEnergetica.A)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
