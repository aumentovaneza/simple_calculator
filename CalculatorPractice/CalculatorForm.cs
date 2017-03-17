using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperatorCalc;

namespace CalculatorPractice
{


    public partial class CalculatorForm : Form
    {

        public CalculatorForm()
        {
            InitializeComponent();
        }

        //Numbers
        private void b1_Click(object sender, EventArgs e)
        {
                textBox.Text += b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
                textBox.Text += b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
                textBox.Text += b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
                textBox.Text += b4.Text;

        }

        private void b5_Click(object sender, EventArgs e)
        {
                textBox.Text += b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
                textBox.Text += b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
                textBox.Text += b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
                textBox.Text += b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
                textBox.Text += b9.Text;
        }

        private void b0_Click(object sender, EventArgs e)
        {
                    textBox.Text += b0.Text;
        }

        private void bPeriod_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += bPeriod.Text;
            }
            else
            {
                MessageBox.Show("There is already a decimal on your equation!");
            }

        }

        //Operators
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("+"))
            {
                textBox.Text += bAdd.Text;
            }
            else
            {
                MessageBox.Show("Unable to create multiple operator!");
            }
            
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("-"))
            {
                textBox.Text += bSub.Text;
            }
            else
            {
                MessageBox.Show("Unable to create multiple operator!");
            }

        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("*"))
            {
                textBox.Text += bMultiply.Text;
            }
            else
            {
                MessageBox.Show("Unable to create multiple operator!");
            }

        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("/"))
            {
                textBox.Text += bDivide.Text;
            }
            else
            {
                MessageBox.Show("Unable to create multiple operator!");
            }

        }

        //Clear button
        private void bClear_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        //solving the equation

        private void bEquals_Click(object sender, EventArgs e)
        {
            double result = calcMechanism.doEquation(textBox.Text);
            string showResult = " ";

            showResult = Convert.ToString(result);

            textBox.Text = string.Empty;
            textBox.Text += showResult;

        }
    }


}
