using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeatCalculatorProject
{
    public partial class Calculator : Form
    {
        public string firstValue = null;
        public string secondValue = null;
        public string operationValue = null;
        public double result = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void BtnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (firstValue == null && operationValue == null)
            {
                firstValue += clickedValue;
                Screen.Text += clickedValue;
            }

            if (firstValue != null && operationValue != null)
            {
                secondValue += clickedValue;
                Screen.Text += clickedValue;
            }
        }

        private void BtnEqualsClick(object sender, EventArgs e)
        {
            double firstNumber, secondNumber;

            if (firstValue != null && secondValue != null && operationValue != null)
            {
                firstNumber = double.Parse(firstValue);
                secondNumber = double.Parse(secondValue);

                if (operationValue == "+")
                {
                    result = firstNumber + secondNumber;
                }
                if (operationValue == "-")
                {
                    result = firstNumber - secondNumber;
                }
                if (operationValue == "*")
                {
                    result = firstNumber * secondNumber;
                }
                if (operationValue == "/")
                {
                    result = firstNumber / secondNumber;
                }

                Screen.Text = result.ToString();

                firstValue = result.ToString();
                secondValue = null;
                operationValue = null;
            }
        }
        private bool CheckScreenText()
        {
            return true;
        }

        private void BtnOperationClick(object sender, EventArgs e)
        {
            operationValue = (sender as Button).Text;

            switch (operationValue)
            {
                case "+":
                    if (!Screen.Text.Contains(operationValue) && firstValue != null)
                    {
                        Screen.Text += " + ";
                    }
                    break;
                case "-":
                    if (!Screen.Text.Contains(operationValue) && firstValue != null)
                    {
                        Screen.Text += " - ";
                    }
                    break;
                case "*":
                    if (!Screen.Text.Contains(operationValue) && firstValue != null)
                    {
                        Screen.Text += " * ";
                    }
                    break;
                case "/":
                    if (!Screen.Text.Contains(operationValue) && firstValue != null)
                    {
                        Screen.Text += " / ";
                    }
                    break;
            }
        }
        private void BtnClearClick(object sender, EventArgs e)
        {
            Screen.Text = "";

            firstValue = string.Empty;
            secondValue = string.Empty;
            operationValue = string.Empty;
        }
    }
}
