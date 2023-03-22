using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void BtnRownosc_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void btnRazy_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void BtnPodziel_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void BtnWyczysc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
