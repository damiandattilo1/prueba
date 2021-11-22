using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace IngresoProductos
{
    public partial class FrmIngresoProductos : Form
    {
        
        public Taller<Producto> listaProductos;
        public int capacidadMaxima;
        public FrmIngresoProductos()
        {
            InitializeComponent();

            this.cmbProducto.Items.AddRange(new String[] { "Microondas", "Aire Acondicionado" });

            this.cmbEficiencia.Items.AddRange(new String[] { "A", "B", "C", "D" });

            this.cmbMarca.Items.AddRange(new String[] { "LG", "Whirlpool", "Philco", "Samsung", "Sony" });

            cmbProducto.Text = ("Ingrese un producto");

            capacidadMaxima = 7;
            listaProductos = new Taller<Producto>(capacidadMaxima);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

             if (cmbProducto.Text == "Aire Acondicionado")
             {
                 EMarca m = (EMarca)Enum.Parse(typeof(EMarca), cmbMarca.Text);
                 EficienciaEnergetica eE = (EficienciaEnergetica)Enum.Parse(typeof(EficienciaEnergetica), cmbEficiencia.Text);
                 ETipo t = (ETipo)Enum.Parse(typeof(ETipo), cmbCaracteristica.Text);

                 AireAcondicionado ac = new AireAcondicionado(Int32.Parse(txtId.Text), m, eE, Int32.Parse(txtPorcentaje.Text), t, Int32.Parse(txtPrecio.Text));
                 if(!listaProductos.Agregar(ac))// && listaProductos.lista.Count == capacidadMaxima)
                 {
                    if(listaProductos.lista.Count == capacidadMaxima)
                    {
                        MessageBox.Show("Taller completo!!!");
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra en la lista!!!");
                    }
                 }

             }
             if (cmbProducto.Text == "Microondas")
             {
                 EMarca m = (EMarca)Enum.Parse(typeof(EMarca), cmbMarca.Text);
                 EficienciaEnergetica eE = (EficienciaEnergetica)Enum.Parse(typeof(EficienciaEnergetica), cmbEficiencia.Text);
                 ETamanio t = (ETamanio)Enum.Parse(typeof(ETamanio), cmbCaracteristica.Text);

                 Microondas mi = new Microondas(Int32.Parse(txtId.Text), m, eE, Int32.Parse(txtPorcentaje.Text), t, Int32.Parse(txtPrecio.Text));
                
                 if (!listaProductos.Agregar(mi))
                 {
                    if (listaProductos.lista.Count == capacidadMaxima)
                    {
                        MessageBox.Show("Taller completo!!!");
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra en la lista!!!");
                    }
                 }
            }

            
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbCaracteristica.Items.Clear();
            if (cmbProducto.Text == "Aire Acondicionado")
                this.cmbCaracteristica.Items.AddRange(new String[] { "Frio", "Calor", "FrioCalor", "Deshumidificador" });
            else if (cmbProducto.Text == "Microondas")
                this.cmbCaracteristica.Items.AddRange(new String[] { " Chico", "Mediano", "Grande" });
            else
                cmbProducto.Text = ("Ingrese un producto");
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            Datos d = new Datos(listaProductos);
            d.ShowDialog();

        }

        private void cmbEficiencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCaracteristica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
