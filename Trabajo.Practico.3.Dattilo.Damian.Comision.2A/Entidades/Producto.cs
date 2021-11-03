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
        protected int porcentajeDeFallas;
        protected int precio;
        protected EMarca marca;

        /// <summary>
        /// Constructor de producto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eficiencia"></param>
        public Producto (int id, EMarca marca, EficienciaEnergetica eficiencia, int porcentaje, int precio)
        {
            this.id = id;
            this.eficiencia = eficiencia;
            this.porcentajeDeFallas = porcentaje;
            this.precio = precio;
            this.marca = marca;
        }

        /// <summary>
        /// Propiedad para Id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        /// <summary>
        /// Propiedad para eficiencia energetica
        /// </summary>
        public EficienciaEnergetica Eficiencia
        {
            get
            {
                return this.eficiencia;
            }
        }


        /// <summary>
        /// Propiedad para porcentaje de fallas
        /// </summary>
        public int PorcentajeDeFallas
        {
            get
            {
                return this.porcentajeDeFallas;
            }
        }
        /// <summary>
        /// Propiedad para precio
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad
        /// </summary>
        /// <param name="p1"></param> Objeto 1 de producto
        /// <param name="p2"></param> Objeto 2 de Producto
        /// <returns></returns>  True si los Id son iguales, de lo contrario False
        public static bool operator ==(Producto p1, Producto p2)
        {
            return ((p1.Id == p2.Id) && (p1.marca == p2.marca));
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Polimorfismo en To String para mostrar por pantalla
        /// </summary>
        /// <returns></returns> Un string conteniendo los datos del producto
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Marca: {this.marca.ToString()}");
            sb.AppendLine($"Eficiencia energetica: {this.Eficiencia}");
            sb.AppendLine($"Porcentaje de fallas: {this.PorcentajeDeFallas}");
            sb.AppendLine($"Precio: {this.Precio}");
            return sb.ToString();
        }

        
    }

}
