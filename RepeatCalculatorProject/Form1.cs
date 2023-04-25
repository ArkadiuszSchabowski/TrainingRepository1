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
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            
            if (Screen.Text != "0")
            {
                Screen.Text += clickedValue;
            }

            if (Screen.Text == "0")
            {
                Screen.Text = "";
                Screen.Text += clickedValue;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {

        }
    }
}
