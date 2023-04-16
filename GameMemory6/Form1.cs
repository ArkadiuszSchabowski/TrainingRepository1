using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory6
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
            AssignIconsToSquares();
        }

        private void label_click(object sender, EventArgs e)
        {
            Label clicledLabel = sender as Label;


            if (firstClicked != null && secondClicked != null)
            {
                return;
            }

            if (clicledLabel == null)
            {
                return;
            }
            if (clicledLabel.ForeColor == Color.Black)
            {
                return;
            }
            if (firstClicked == null)
            {
                firstClicked = clicledLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clicledLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;

                CheckForWinner();
            }
            else
            timer1.Start();
        }
        private void CheckForWinner()
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

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void AssignIconsToSquares()
        {
            Label label;
            int position;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];

                    position = rnd.Next(0, list.Count);
                    label.Text = list[position];

                    list.RemoveAt(position);
                }

            }
        }
    }
}
