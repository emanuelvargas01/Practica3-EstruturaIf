using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_EstruturaIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal num1;
        decimal num2;
        decimal resultado;
        private void rbnSuma_CheckedChanged(object sender, EventArgs e)
        {
           if(rbnSuma.Checked == true)
                lblOperacion.Text = "+";
            if (decimal.TryParse(txt1.Text, out num1) && decimal.TryParse(txt2.Text, out num2))
                { 
                resultado = num1 + num2;
                
                txtResultado.Text = resultado.ToString();
            }
            else {
                MessageBox.Show("Debe ingresar los dos operandos para poder realizar el calculo");
            }

           
        }

        private void rbtnResta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnResta.Checked == true)
                lblOperacion.Text = "-";
            if (decimal.TryParse(txt1.Text, out num1) && decimal.TryParse(txt2.Text, out num2))
                {
                    resultado = num1 - num2;

                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Debe ingresar los dos operandos para poder realizar el calculo");
                }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            rbnSuma.Checked = false;
            rbtnResta.Checked = false;
            rbtnMultiplicacion.Checked = false;
            rbtnDivision.Checked = false;
            lblOperacion.Text = "";
        }

        private void rbtnMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMultiplicacion.Checked == true)
                lblOperacion.Text = "*";
            if (decimal.TryParse(txt1.Text, out num1) && decimal.TryParse(txt2.Text, out num2))
                {
                    resultado = num1 * num2;

                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Debe ingresar los dos operandos para poder realizar el calculo");
                }
        }

        private void rbtnDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDivision.Checked == true)
                lblOperacion.Text = "/";
                if (decimal.TryParse(txt1.Text, out num1) && decimal.TryParse(txt2.Text, out num2))
                {
                    resultado = num1 / num2;

                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Debe ingresar los dos operandos para poder realizar el calculo");
                }
        }
    }
}
