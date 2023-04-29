using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnProjectSaveTheCarrot
{
    public partial class PigGame : Form
    {
        Random rndX = new Random();
        Random rndY = new Random();

        bool goLeft, goRight;
        int score = 0;
        int missed = 0;
        int speed = 5;

        public PigGame()
        {
            InitializeComponent();
            RestartGame();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + score;
            labelMissed.Text = "Missed: " + missed;

            if (goLeft == true && GuineaPig.Left > 0)
            {
                GuineaPig.Left -= 12;
                GuineaPig.Image = Properties.Resources.guineapig;
            }
            if (goRight == true && GuineaPig.Right < this.ClientSize.Width)
            {
                GuineaPig.Left += 12;
                GuineaPig.Image = Properties.Resources.guineaPigRight;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "carrot")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        x.Top = rndY.Next(80, 300) * -1;
                        x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                        missed += 1;
                        GuineaPig.Image = Properties.Resources.Miss;
                    }

                    if (GuineaPig.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = rndY.Next(80, 300) * -1;
                        x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                        score += 5;
                    }

                    if (score == 50)
                    {
                        speed = 7;
                    }

                    if (score == 100)
                    {
                        speed = 9;
                    }
                }
            }
            if (missed > 4)
            {
                GameTimer.Stop();
                labelMissed.Text = "Missed: 5";
                MessageBox.Show($"Game over! {Environment.NewLine} Your score is {score}!{Environment.NewLine}{Environment.NewLine} Press ok to restart game!");
                RestartGame();
            }
        }

        public void RestartGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "carrot")
                {
                    x.Top = rndY.Next(80, 300) * -1;
                    x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);
                }

                goLeft = false;
                goRight = false;

                score = 0;
                missed = 0;
                speed = 5;

                GuineaPig.Image = Properties.Resources.guineapig;
                GuineaPig.Left = ClientSize.Width / 2;

                GameTimer.Start();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
