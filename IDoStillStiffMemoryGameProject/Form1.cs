using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDoStillStiffMemoryGameProject
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<string> list = new List<string>()
        {
            "a", "a", "%", "%", "c", "c", "d", "d",
            "e", "e", "f", "f", "g", "g", "h", "h"
        };
        Label firstClicked, secondClicked;
        public Form1()
        {
            InitializeComponent();
            AssignImagesToTheSquares();
        }

        private void label_click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (firstClicked != null && secondClicked != null)
            {
                return;
            }

            if (clickedLabel == null)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            else
                timer1.Start();
        }
        private void CheckWinner()
        {
            Label label;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = Color.Olive;
            secondClicked.ForeColor = Color.Olive;

            firstClicked = null;
            secondClicked = null;
        }

        private void AssignImagesToTheSquares()
        {
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = tableLayoutPanel1.Controls[i] as Label;
                }
                else
                {
                    continue;
                }
                randomNumber = rnd.Next(0, list.Count);
                label.Text = list[randomNumber];

                list.RemoveAt(randomNumber);
            }
        }
    }
}
