using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongDateString();
            combo.Items.Clear();
            combo.Items.Add("Gerente");
            combo.Items.Add("SubGerente");
            combo.Items.Add("Secretaria");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string combito = combo.Text;
            double salario = double.Parse(txtsalario.Text);
            double descuento = 0.20;
            double salarioFinal = 0;

            switch(combito)
            {
                case "Gerente":
                    descuento = salario * 0.20;
                    salarioFinal = salario - descuento;
                    break;
                case "SubGerente":
                    descuento = salario * 0.15;
                    salarioFinal = salario - descuento;

                    break;
                case "Secretaria":
                    descuento = salario * 0.05;
                    salarioFinal = salario - descuento;
                    break;
            }

            MessageBox.Show("Amigo " + nombre + " su salario aplicando descuentos será de: " +" $ " +salarioFinal + " Dolares");
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
