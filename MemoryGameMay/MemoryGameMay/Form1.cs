using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameMay
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<string> list = new List<string>
        {
            "a","a","Q","Q","C","C", "X","X",
            "d","d","M","M","Z","Z","I","I",
        };
        Label firstClicked;
        Label secondClicked;
        public Form1()
        {
            InitializeComponent();
            AssignItemsToSquares();
        }
        public void AssignItemsToSquares()
        {
            Label label;
            int position;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                position = rnd.Next(0, list.Count);
                label.Text = list[position];

                list.RemoveAt(position);
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel;
            clickedLabel = sender as Label;

            if (firstClicked != null && secondClicked != null)
            {
                return;
            }

            if (clickedLabel == null)
            {
                return;
            }

            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                CheckForWinner();
            }
            else
            {
                timer1.Start();
            }

        }
        private void CheckForWinner()
        {
            Label check;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                check = tableLayoutPanel1.Controls[i] as Label;

                if (check.ForeColor != Color.Black)
                {
                    return;
                }
            }
            MessageBox.Show("Congratulations!");
            Close();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }
    }
}
