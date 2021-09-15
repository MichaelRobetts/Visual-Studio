using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        private decimal valuefirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "0";
            }
            else
            {
                calculatorDisplay.Text += "0";
            }
        }

       
        private void oneButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "1";
            }
            else
            {
                calculatorDisplay.Text += "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "2";
            }
            else
            {
                calculatorDisplay.Text += "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "3";
            }
            else
            {
                calculatorDisplay.Text += "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "4";
            }
            else
            {
                calculatorDisplay.Text += "4";
            }
        }
        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "5";
            }
            else
            {
                calculatorDisplay.Text += "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "6";
            }
            else
            {
                calculatorDisplay.Text += "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "7";
            }
            else
            {
                calculatorDisplay.Text += "7";
            }
        }
        private void eightbutton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "8";
            }
            else
            {
                calculatorDisplay.Text += "8";
            }
        }
        private void nineButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "9";
            }
            else
            {
                calculatorDisplay.Text += "9";
            }
        }
   
        private void divideButton_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
            operators = "/";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            valuefirst = 0.0m;
            valueSecond = 0.0m;
            Result = 0.0m;
            calculatorDisplay.Text = "0";
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
            operators = "+";
        }
        

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!calculatorDisplay.Text.Contains("."))
            {
                calculatorDisplay.Text += ".";
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch (operators) 
            {
                case "-":
                    valueSecond = decimal.Parse(calculatorDisplay.Text);
                    Result = valuefirst - valueSecond;
                    calculatorDisplay.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(calculatorDisplay.Text);
                    Result = valuefirst + valueSecond;
                    calculatorDisplay.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(calculatorDisplay.Text);
                    Result = valuefirst / valueSecond;
                    calculatorDisplay.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(calculatorDisplay.Text);
                    Result = valuefirst * valueSecond;
                    calculatorDisplay.Text = Result.ToString();
                    break;
                case "%":
                    valueSecond = decimal.Parse(calculatorDisplay.Text);
                    Result = valuefirst % valueSecond;
                    calculatorDisplay.Text = Result.ToString();
                    break;

            }
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
            operators = "-";
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
            operators = "*";
        }
        private void calculatorDisplay_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void MinusPlusButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text.Contains("-"))
            {
                calculatorDisplay.Text = calculatorDisplay.Text.Trim('-');
            }
            else
            {
                calculatorDisplay.Text = "-" + calculatorDisplay.Text;
            }
        }

        private void modulusButton_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(calculatorDisplay.Text);
            calculatorDisplay.Clear();
            operators = "%";
        }
    }
}
