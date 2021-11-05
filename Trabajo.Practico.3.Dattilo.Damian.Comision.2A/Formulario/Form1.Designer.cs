
namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.elegirClase = new System.Windows.Forms.ComboBox();
            this.eficiencia = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.porcentajeFallas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.caracteristica = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elegirClase
            // 
            this.elegirClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elegirClase.FormattingEnabled = true;
            this.elegirClase.Location = new System.Drawing.Point(240, 66);
            this.elegirClase.Name = "elegirClase";
            this.elegirClase.Size = new System.Drawing.Size(121, 24);
            this.elegirClase.TabIndex = 0;
            // 
            // eficiencia
            // 
            this.eficiencia.BackColor = System.Drawing.SystemColors.Window;
            this.eficiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eficiencia.FormattingEnabled = true;
            this.eficiencia.Location = new System.Drawing.Point(375, 177);
            this.eficiencia.Name = "eficiencia";
            this.eficiencia.Size = new System.Drawing.Size(121, 24);
            this.eficiencia.TabIndex = 1;
            this.eficiencia.Tag = "";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(64, 175);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 3;
            this.id.TextChanged += new System.EventHandler(this.id1_TextChanged);
            // 
            // porcentajeFallas
            // 
            this.porcentajeFallas.Location = new System.Drawing.Point(567, 175);
            this.porcentajeFallas.Name = "porcentajeFallas";
            this.porcentajeFallas.Size = new System.Drawing.Size(100, 22);
            this.porcentajeFallas.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "btnOperar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marca
            // 
            this.marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marca.FormattingEnabled = true;
            this.marca.Location = new System.Drawing.Point(199, 173);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(121, 24);
            this.marca.TabIndex = 6;
            this.marca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione un producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Porcentaje de fallas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione Eficiencia Energetica 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese  ID 1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(925, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 292);
            this.listBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Marca\r\n";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(748, 179);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 22);
            this.precio.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(730, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio";
            // 
            // caracteristica
            // 
            this.caracteristica.BackColor = System.Drawing.SystemColors.Window;
            this.caracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caracteristica.FormattingEnabled = true;
            this.caracteristica.Location = new System.Drawing.Point(375, 271);
            this.caracteristica.Name = "caracteristica";
            this.caracteristica.Size = new System.Drawing.Size(121, 24);
            this.caracteristica.TabIndex = 20;
            this.caracteristica.Tag = "";
            this.caracteristica.SelectedIndexChanged += new System.EventHandler(this.caracteristica_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Seleccione Caracteristica";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caracteristica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.porcentajeFallas);
            this.Controls.Add(this.id);
            this.Controls.Add(this.eficiencia);
            this.Controls.Add(this.elegirClase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox elegirClase;
        private System.Windows.Forms.ComboBox eficiencia;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox porcentajeFallas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox caracteristica;
        private System.Windows.Forms.Label label3;
    }
}

