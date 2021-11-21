using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace IngresoProductos
{
    public partial class Datos : Form
    {
        //public Taller<AireAcondicionado> aires;
        //public Taller<Microondas> micros;
        public Taller<Producto> lista;

        public Datos(Taller<Producto> productos)//(Taller<AireAcondicionado> listaAires, Taller<Microondas> listaMicros)
        {
            InitializeComponent();

            //this.aires = listaAires;
            //this.micros = listaMicros;
            this.lista = productos;
            Imprimir();
        }

        private void Imprimir()
        {
            StringBuilder sb = new StringBuilder();

            /*sb.AppendLine("Taller de Aires Acondicionados\n");

            foreach (AireAcondicionado item in aires.lista)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("\nTaller de Microondas\n");

            foreach (Microondas item in micros.lista)
            {
                sb.AppendLine(item.ToString());
            }
            */

            sb.AppendLine("Lista del Taller\n");

            foreach (Producto item in lista.lista)
            {
                if (item is Microondas)
                    sb.AppendLine($"Categoria: Microondas");
                else
                    sb.AppendLine($"Categoria: Aire Acondicionado");
                
                sb.AppendLine(item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
