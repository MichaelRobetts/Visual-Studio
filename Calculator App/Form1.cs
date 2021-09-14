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
       string userInput = "";
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

       
        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "4";
        }
        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "7";
        }
        private void eightbutton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "8";
        }
        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "9";
        }
   
        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            function = 'd';
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
        }
        private void calculatorDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += ".";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            function = '=';
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            //Another commit
            function = '-';
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            //Comment to test git
            function = 'x';
        }

    }
}
