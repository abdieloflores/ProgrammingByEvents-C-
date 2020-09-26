using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        int countSum = 0, countRes=0, countMul=0, countDiv=0;
        double primero,segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMulti obj3 = new Clases.ClsMulti();
        Clases.ClsDivi obj4 = new Clases.ClsDivi();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "" && primero <= 0)
            {
            }
            else
            {
                operador = "+";
                countSum++;

                if (countSum <= 1)
                {
                    primero = double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
                else
                {
                    primero += double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
            primero = 0;
            segundo = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "" && primero <= 0)
            {
            }
            else
            {
                if (tbxScreen.Text.Length == 1)
                    tbxScreen.Text = "";
                else
                    tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "" && primero <= 0) {
            } else { 
                operador = "-";
                countRes++;
                primero = double.Parse(tbxScreen.Text);

                if (countRes <= 1)
                {
                    primero = double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
                else
                {
                    primero -= double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "" && primero <= 0)
            {
            }
            else
            {
                operador = "*";
                countMul++;
                primero = double.Parse(tbxScreen.Text);

                if (countMul <= 1)
                {
                    primero = double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
                else
                {
                    primero *= double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
            }
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "" && primero <= 0)
            {
            }
            else
            {
                operador = "/";
                countDiv++;

                if (countDiv <= 1)
                {
                    primero = double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
                else
                {
                    primero /= double.Parse(tbxScreen.Text);
                    tbxScreen.Clear();
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text == "" && primero <= 0)
            {
            }
            else
            {
                segundo = double.Parse(tbxScreen.Text);

                double sum, rest, mult, div;

                switch (operador)
                {
                    case "+":
                        sum = obj.Sumar(primero, segundo);
                        tbxScreen.Text = sum.ToString();
                        countSum = 0;
                        break;
                    case "-":
                        rest = obj2.Restar(primero, segundo);
                        tbxScreen.Text = rest.ToString();
                        countRes = 0;
                        break;
                    case "*":
                        mult = obj3.Multi(primero, segundo);
                        tbxScreen.Text = mult.ToString();
                        countMul = 0;
                        break;
                    case "/":
                        div = obj4.Divi(primero, segundo);
                        tbxScreen.Text = div.ToString();
                        countDiv = 0;
                        break;
                }
            }
        }
    }
}
