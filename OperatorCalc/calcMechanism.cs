using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorCalc
{

    public class detOp
    {
        public char determineOperator(string textInTextBox)
        {
            char op = ' ';

            if (textInTextBox.Contains('+'))
            {
                op = '+';

                return op;
            }
            else if (textInTextBox.Contains('-'))
            {
                op = '-';

                return op;
            }
            else if (textInTextBox.Contains('*'))
            {
                op = '*';

                return op;
            }
            else if (textInTextBox.Contains('/'))
            {
                op = '/';

                return op;
            }
            else
            {
                MessageBox.Show("No Operator Found");
            }

            return op;
        }
    }

    public static class calcMechanism
    {
        

        public static double doEquation(string textboxValue)
        {

            var op = new detOp();
            char o;

            o = op.determineOperator(textboxValue);

            double firstValue = 0.0;
            double secondValue = 0.0;
            double result = 0.0;


                string[] equation = textboxValue.Split(o);

                firstValue = Convert.ToDouble(equation[0]);
                secondValue = Convert.ToDouble(equation[1]);

                if (o == '+')
                {
                   return result = firstValue + secondValue;
                }
                else if(o == '-')
                {
                   return result = firstValue - secondValue;
                }
                else if (o == '*')
                {
                   return result = firstValue * secondValue;
                }
                else if (o == '/')
                {
                    return result = firstValue / secondValue;
                }
                else
                {
                    return result;
                }

        }

    }
}
