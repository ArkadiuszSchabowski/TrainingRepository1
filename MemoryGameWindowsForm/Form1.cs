using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGameWindowsForm
{
    public partial class Form1 : Form
    {
        private const int CARD_WIDTH = 80;
        private const int CARD_HEIGHT = 100;
        private const int ROWS = 4;
        private const int COLUMNS = 4;
        private const int NUM_CARDS = ROWS * COLUMNS;
        private readonly Random _random = new Random();

        private readonly PictureBox[] _cards = new PictureBox[NUM_CARDS];
        private readonly Image[] _cardImages = new Image[NUM_CARDS / 2];

        private int _card1 = -1;
        private int _card2 = -1;
        private int _cardsLeft = NUM_CARDS;

        public Form1()
        {
            InitializeComponent();
            LoadCardImages();
            CreateCards();
        }

        private void LoadCardImages()
        {
            for (int i = 0; i < NUM_CARDS / 2; i++)
            {
                _cardImages[i] = Image.FromFile($"images/{i + 1}.jpg");
            }
        }

        private void CreateCards()
        {
            for (int i = 0; i < NUM_CARDS; i++)
            {
                var card = new PictureBox
                {
                    Width = CARD_WIDTH,
                    Height = CARD_HEIGHT,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = i
                };

                card.Click += Card_Click;

                _cards[i] = card;
                Controls.Add(card);
            }

            ArrangeCards();
        }

        private void ArrangeCards()
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLUMNS; col++)
                {
                    int index = row * COLUMNS + col;
                    _cards[index].Location = new Point(col * CARD_WIDTH, row * CARD_HEIGHT);
                }
            }

            ShuffleCards();
        }

        private void ShuffleCards()
        {
            for (int i = 0; i < NUM_CARDS; i++)
            {
                int j = _random.Next(NUM_CARDS);
                var temp = _cards[i];
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            var card = (PictureBox)sender;
            int index = (int)card.Tag;

            if (index == _card1 || index == _card2)
            {
                return;
            }

            card.Image = _cardImages[index % (_cardImages.Length)];

            if (_card1 == -1)
            {
                _card1 = index;
            }
            else if (_card2 == -1)
            {
                _card2 = index;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            var card1 = _cards[_card1];
            var card2 = _cards[_card2];

            if (card1.Image == card2.Image)
            {
                card1.Visible = false;
                card2.Visible = false;
                _cardsLeft -= 2;

                if (_cardsLeft == 0)
                {
                    MessageBox.Show("Gratulacje, uda³o Ci siê ukoñczyæ grê!");
                    Application.Exit();
                }
            }
            else
            {
                card1.Image = null;
                card2.Image = null;
            }
        }
    }
}



