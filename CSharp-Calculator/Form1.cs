using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Calculator
{
    public partial class Form1 : Form
    {
        string currentOperator;
        double result = 0;
        bool isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(summaryDisplay.Text.Split(' ').Last(), out double secondNumber))
            {
                switch (currentOperator)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        result /= secondNumber;
                        break;
                }

                mainDisplay.Text = result.ToString(); 
                summaryDisplay.Text = result.ToString(); 
                isNewEntry = true;
            }
        }
        private void oneBtn_Click_1(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }
        private void twoBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (isNewEntry)
            {
                summaryDisplay.Text = button.Text;
                isNewEntry = false;
            }
            else
            {
                summaryDisplay.Text += button.Text;
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (double.TryParse(summaryDisplay.Text, out double currentNumber))
            {
                result = currentNumber;
                currentOperator = button.Text;
                mainDisplay.Text = result.ToString();
                summaryDisplay.Text += " " + currentOperator + " ";
                isNewEntry = true;
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (double.TryParse(summaryDisplay.Text, out double currentNumber))
            {
                result = currentNumber;
                currentOperator = button.Text;
                mainDisplay.Text = result.ToString();
                summaryDisplay.Text += " " + currentOperator + " "; 
                isNewEntry = true;
            }
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (double.TryParse(summaryDisplay.Text, out double currentNumber))
            {
                result = currentNumber;
                currentOperator = "*";
                mainDisplay.Text = result.ToString();
                summaryDisplay.Text += " " + currentOperator + " "; 
                isNewEntry = true;
            }
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (double.TryParse(summaryDisplay.Text, out double currentNumber))
            {
                result = currentNumber;
                currentOperator = "/";
                mainDisplay.Text = result.ToString();
                summaryDisplay.Text += " " + currentOperator + " "; 
                isNewEntry = true;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            summaryDisplay.Text = "";
            mainDisplay.Text = "";
            result = 0;
            currentOperator = "";
            isNewEntry = true;
        }
    }
}
