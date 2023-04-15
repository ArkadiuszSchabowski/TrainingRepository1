using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> lista = new List<string>()
        {
            "a", "a", "b", "b", "c", "c","d", "d",
            "e", "e", "f", "f", "g", "g","h", "h"
        };

        Label firstClicked, secondClicked;  

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label_click(object sender, EventArgs e)
        {
            if (firstClicked != null & secondClicked != null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black)
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                clickedLabel.ForeColor = Color.Black;
                return;
            }

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = Color.Orange;
            secondClicked.ForeColor = Color.Orange;

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
                }
                else
                    continue;

                position = random.Next(0, lista.Count);
                label.Text = lista[position];

                lista.RemoveAt(position);
            }
        }
    }
}
