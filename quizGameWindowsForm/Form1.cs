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
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentAge;
        int totalQuestions;


        public bool isClicked = false;
        public int points = 0;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        public void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.rozetka;
                    lblText.Text = "Jakiej rasy jest swinka przedstawiona na obrazku?";
                    btnA.Text = " A. Skinny";
                    btnB.Text = " B. Peruwianka";
                    btnC.Text = " C. Rozetka";
                    btnD.Text = " D. Dlugowlosa";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.swinka_morska_kawia_domowa;
                    lblText.Text = "Na czym z wymienionych produktow najlepiej zetrze zeby swinka morska?";
                    btnA.Text = "A. Siano";
                    btnB.Text = "B. Marchew";
                    btnC.Text = "C. Banan";
                    btnD.Text = "D. Ogorek";
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.teddy;
                    lblText.Text = "Pytanie 2.Jak Inaczej kiedyś nazywano świnkę morską ?";
                    btnA.Text = "A - świnką miniaturową";
                    btnB.Text = "B - powiększonym chomikiem";
                    btnC.Text = "C - uszatniczką";
                    btnD.Text = "D - świnką nadmorską";
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.skinny;
                    lblText.Text = "Jakiej rasy jest swinka przedstawiona na obrazku?";
                    btnA.Text = " A. Rozetka";
                    btnB.Text = " B. Teddy";
                    btnC.Text = " C. Sheltie";
                    btnD.Text = " D. Skinny";
                    break;
            }
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {

        }
    }
}
