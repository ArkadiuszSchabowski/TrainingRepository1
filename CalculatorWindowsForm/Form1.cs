using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnNumberClick(object sender, MouseEventArgs e)
        {
            var ClickedValue = (sender as Button).Text;

            tbScreen.Text += ClickedValue;
        }
    }
}
