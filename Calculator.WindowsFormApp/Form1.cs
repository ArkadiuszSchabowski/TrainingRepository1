using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            tbScreen.Text += clickedValue;
        }
    }
}
