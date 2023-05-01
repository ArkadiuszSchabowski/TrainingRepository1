using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGameWindowsForm
{
    public partial class Form1 : Form
    {
        public bool isClicked = false;
        public int points = 0;
        public Form1()
        {
            InitializeComponent();
            QuestionOne();
        }

        public void QuestionOne()
        {
            string firstAnswer = "";

            pictureBox1.Image = Properties.Resources.rozetka;
            textBox1.Text = "Jakiej rasy jest swinka przedstawiona na obrazku?";
            btnA.Text = " A. Skinny";
            btnB.Text = " B. Peruwianka";
            btnC.Text = " C. Rozetka";
            btnD.Text = " D. Dlugowlosa";

            if (firstAnswer == "C. Rozetka")
            {
                QuestionTwo();
            }
        }

        private void QuestionTwo()
        {
            pictureBox1.Image = Properties.Resources.skinny;
            textBox1.Text = "Jakiej rasy jest swinka przedstawiona na obrazku?";
            btnA.Text = "A. Skinny";
            btnB.Text = "B. Peruwianka";
            btnC.Text = "C. Rozetka";
            btnD.Text = "D. Dlugowlosa";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string Answer = (sender as Button).Text;

            if (Answer == "A. Skinny")
            {
                isClicked = true;
            }

            if (Answer == "B. Peruwianka")
            {
                isClicked = true;
            }

            if (Answer == "C. Rozetka")
            {
                isClicked = true;
            }

            if (Answer == "D. Dlugowlosa")
            {
                isClicked = true;
            }
        }
    }
}
