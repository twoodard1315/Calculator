using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String keyStrokes = String.Empty; //store button clicked
        public const double PI = 3.14159265358979;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelExpression.Text = String.Empty;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender; //get button clicked                       

            if (button.Text == "C") //clears last enter number
            {
                int keyStrokesLength = keyStrokes.Length;
                keyStrokes = keyStrokes.Remove(keyStrokesLength - 1);
                labelExpression.Text = keyStrokes;
            }

            else if (button.Text == "Clear All") //clears expression
            {
                keyStrokes = String.Empty;
                textBoxDisplay.Text = String.Empty;
                labelExpression.Text = String.Empty;
            }

            else if (button.Text == "%") //calculates percentages
            {
                double doubleKeyStrokes = Convert.ToDouble(keyStrokes);
                textBoxDisplay.Text = button.Text;

                if (doubleKeyStrokes >= 1) //converts percent to decimal
                {
                    double toPercentKeyStrokes = doubleKeyStrokes / 100;
                    textBoxDisplay.Text = Convert.ToString(toPercentKeyStrokes);
                }

                else //converts decimal to percent
                {
                    double fromPercentKeyStrokes = doubleKeyStrokes * 100;
                    textBoxDisplay.Text = Convert.ToString(fromPercentKeyStrokes);
                }

            }

            else if (button.Text == "sin") //calculates sin, default unit is radians
            {
                double keyStrokesSin = Math.Sin(Convert.ToDouble(keyStrokes));
                textBoxDisplay.Text = Convert.ToString(keyStrokesSin);
            }

            else if (button.Text == "cos") //Calcualates cos, default unit is radians
            {
                double keyStrokesCos = Math.Cos(Convert.ToDouble(keyStrokes));
                textBoxDisplay.Text = Convert.ToString(keyStrokesCos);
            }

            else if (button.Text == "tan") //calculates tan, default unit is radians
            {
                double keyStrokesTan = Math.Tan(Convert.ToDouble(keyStrokes));
                textBoxDisplay.Text = Convert.ToString(keyStrokesTan);
            }

            else if (button.Text == "log") //get checked
            {
                double keyStrokesLog = Math.Log10(Convert.ToDouble(keyStrokes));
                textBoxDisplay.Text = Convert.ToString(keyStrokesLog);
            }

            else if (button.Text == "ln") //get checked
            {
                double keyStrokesLog = Math.Log(Convert.ToDouble(keyStrokes));
                textBoxDisplay.Text = Convert.ToString(keyStrokesLog);
            }

            else if (button.Text == "1/x") //reciprocal
            {
                double keyStrokesRecip = 1 / Convert.ToDouble(keyStrokes);
                textBoxDisplay.Text = Convert.ToString(keyStrokesRecip);
            }

            else if (button.Text == "|x|") //absolute value
            {
                double keyStrokesAbs = Math.Abs(Convert.ToDouble(keyStrokes));
                textBoxDisplay.Text = Convert.ToString(keyStrokesAbs);
            }

            else if (button.Text == "√") //square root the number 
            {
                double keyStrokesSquare = Math.Sqrt(Convert.ToDouble(keyStrokes));
                textBoxDisplay.Text = Convert.ToString(keyStrokesSquare);
            }

            /*else if (button.Text == "^") //raise the first number by the second number 
            {
                string[] exponents = keyStrokes.Split('^');

                double num1 = Convert.ToDouble(exponents[0]);
                double num2 = Convert.ToDouble(exponents[1]);

                double keyStrokesPow = Math.Pow(num1, num2);
                textBoxDisplay.Text = Convert.ToString(keyStrokesPow);
            }*/

            else if (button.Text == "π")//input pi into keystrokes
            {
                keyStrokes += PI;
                textBoxDisplay.Text = "π";
                labelExpression.Text = keyStrokes;

            }

            else if (button.Text == "+/-") //change from positive to negative
            {
                keyStrokes += "-";
                textBoxDisplay.Text = "+/-";
                //labelExpression.Text = "-";
            }

            /*else if (button.Text == "EE") //convert to scientific notation
            {
                //string keyStrokesSciNot = String.Format("{0:#.##e-00}", keyStrokes);
                textBoxDisplay.Text = string.Format("{0:E2}", keyStrokes);
            }*/

            else if (button.Text == "Unit Convert")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }


            else if (button.Text != "=") // deals with all number buttons and function buttons
            {
                keyStrokes += button.Text;
                labelExpression.Text = keyStrokes;
                textBoxDisplay.Text = button.Text;
                return;
            }
            
            
            if (button.Text == "=") //calculates numerical expression when = clicked
            {
                textBoxDisplay.Text = button.Text;

                Expression expression = new Expression(keyStrokes);
                textBoxDisplay.Text = Convert.ToString(expression.Evaluate());
            }

           
        }

        
    }
}
