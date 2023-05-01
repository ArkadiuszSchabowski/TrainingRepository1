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
        public Form1()
        {
            InitializeComponent();
            QuestionOne();
        }

        public void QuestionOne()
        {
            pictureBox1.Image = Properties.Resources.rozetka;
            textBox1.Text = "Jakiej rasy jest swinka przedstawiona na obrazku?";
            btnA.Text = " A - Skinny";
            btnB.Text = " B - Peruwianka";
            btnC.Text = " C - Rozetka";
            btnD.Text = " D - Dlugowlosa";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string Answer = (sender as Button).Text;

            switch (Answer)
            {
                case "A":
                    break;
                case "B":
                    break;
                case "C":
                    break;
                case "D":
                    break;
            }
        }
    }
}
