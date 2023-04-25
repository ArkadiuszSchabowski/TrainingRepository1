using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeInApril
{
    public partial class Form1 : Form
    {
        private int turn = 0;
        private Label label;
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckResult()
        {

            if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }
            if (label4.Text == "X" && label5.Text == "X" && label6.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }
            if (label7.Text == "X" && label8.Text == "X" && label9.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }
            if (label1.Text == "X" && label4.Text == "X" && label7.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }
            if (label2.Text == "X" && label5.Text == "X" && label8.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }
            if (label3.Text == "X" && label6.Text == "X" && label9.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }
            if (label1.Text == "X" && label5.Text == "X" && label9.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }
            if (label3.Text == "X" && label5.Text == "X" && label7.Text == "X")
            {
                MessageBox.Show("The first player win!");
            }

            if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }
            if (label4.Text == "O" && label5.Text == "O" && label6.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }
            if (label7.Text == "O" && label8.Text == "O" && label9.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }
            if (label1.Text == "O" && label4.Text == "O" && label7.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }
            if (label2.Text == "O" && label5.Text == "O" && label8.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }
            if (label3.Text == "O" && label6.Text == "O" && label9.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }
            if (label1.Text == "O" && label5.Text == "O" && label9.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }
            if (label3.Text == "O" && label5.Text == "O" && label7.Text == "O")
            {
                MessageBox.Show("The second player win!");
            }

            bool isDraw = true;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                Label checkDraw = tableLayoutPanel1.Controls[i] as Label;

                if (checkDraw.Text == "")
                {
                    isDraw = false;
                    break;
                }
            }
            if (isDraw)
            {
                    MessageBox.Show("It's a draw!");
                    return;
            }
        }

        private void label_click(object sender, EventArgs e)
        {

            label = sender as Label;

            if (label.Text != "")
            {
                MessageBox.Show("To pole jest juz zajete!");
                return;
            }

            else
            {
                if (turn % 2 == 0)
                {
                    label.Text = "X";
                }
                else
                {
                    label.Text = "O";
                }
                turn++;
            }
            CheckResult();
        }
    }
}
