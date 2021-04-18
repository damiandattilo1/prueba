using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades5;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.Text = "Calculadora de Dattilo, Damian del curso 2A";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cmbOperador.Items.AddRange(new String[] {"+", "-", "*", "/"});
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;

            Numero n1 = new Numero(this.txtNumero1.Text);
            Numero n2 = new Numero(this.txtNumero2.Text);

            resultado = Calculadora.Operar (n1, n2, cmbOperador.Text);

            this.lblResultado.Text = (Convert.ToString(resultado));

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            
             this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
          
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            
            this.lblResultado.Text = Convert.ToString(Numero.BinarioDecimal(this.lblResultado.Text));
            
        }

    }
}
