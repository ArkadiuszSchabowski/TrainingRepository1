using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalculator
{
    public enum Operation
    {
        Addition, Substraction, Division, Multiplication, None
    }
    public partial class Form1 : Form
    {
        private string _firstValue = null;
        private Operation _currentOperation = Operation.None;
        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (tbScreen.Text == "0")
                tbScreen.Text = string.Empty;

            tbScreen.Text += clickedValue;
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;
            var operation = (sender as Button).Text;

            _currentOperation = operation switch

            {

            } ;

            tbScreen.Text += $" {operation }";
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            tbScreen.Text = "0";
        }
    }
}
