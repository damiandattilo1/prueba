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
        
        public Taller<Producto> lista;

        public Datos(Taller<Producto> productos)
        {
            InitializeComponent();

            this.lista = productos;
            Imprimir();
        }

        private void Imprimir()
        {
            StringBuilder sb = new StringBuilder();

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
