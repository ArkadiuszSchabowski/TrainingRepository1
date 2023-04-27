using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheEgg
{
    public partial class MainWindow : Form
    {
        bool goLeft, goRight;
        int speed = 8;
        int score = 0;
        int missed = 0;

        Random rndX = new Random();
        Random rndY = new Random();

        PictureBox splash = new PictureBox();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void MainGameTimer(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top = rndY.Next(80, 300) * -1;
                    x.Left = rndX.Next(5, this.ClientSize.Width - x.Width);

                    player.Left = this.ClientSize.Width / 2;
                }
            }
        }
    }
}
