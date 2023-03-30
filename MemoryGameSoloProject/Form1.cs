using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//W grze Memory gracz musi odkrywa� karty, kt�re s� u�o�one w losowej kolejno�ci na planszy, w celu znalezienia par takich samych kart. Je�li gracz odgadnie par�, karty pozostaj� odkryte, a gracz zdobywa punkt. Je�li gracz nie odgadnie pary, karty zostaj� zakryte i gracz musi spr�bowa� ponownie. Gra ko�czy si�, gdy wszystkie pary zostan� odgadni�te.

//W celu zaimplementowania tych zasad w kodzie, mo�na rozpocz�� od dodania do ka�dej karty (w postaci obiektu PictureBox) atrybutu "par�" lub "identyfikator" (np. karty 1-8, ka�da z nich ma swojego "partnera" na planszy). Nast�pnie, mo�na utworzy� tablic� lub list�, kt�ra zawiera informacje o stanie ka�dej karty (czy jest odkryta czy zakryta).

//Gdy gracz kliknie na kart�, nale�y zmieni� jej stan z zakrytej na odkryt�, a nast�pnie por�wna� j� z innymi odkrytymi kartami w celu znalezienia pary. Je�li odgadni�to par�, karty pozostaj� odkryte i gracz zdobywa punkt, je�li nie, karty zostaj� zakryte i gra toczy si� dalej.

//Je�li wszystkie pary zostan� odgadni�te, gra ko�czy si�, a gracz otrzymuje wynik. W tym momencie mo�na da� graczowi mo�liwo�� rozpocz�cia nowej gry lub zako�czenia gry.

//Pami�taj, �e powy�szy opis jest tylko wskaz�wk�, a implementacja zasad gry Memory mo�e wymaga� dodatkowych krok�w i modyfikacji w zale�no�ci od preferencji i potrzeb.
namespace MemoryGameSoloProject
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<PictureBox> pictureBoxList = new List<PictureBox>();
        bool[] cardsState = new bool[16]; // utworzenie tablicy przechowuj�cej informacje o stanie ka�dej karty
        PictureBox firstCard = null;

        public Form1()
        {
            InitializeComponent();
            AddPicturesToList();
            HidePictures();
        }

        private void HidePictures()
        {
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                pictureBoxList[i].BackColor = Color.LightGray;
                pictureBoxList[i].Image = null;
                cardsState[i] = false; // ustawienie stanu ka�dej karty na zakryt� (false)
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox pic in pictureBoxList)
            {
                pic.Click += new EventHandler(PictureBox_Click);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            if (pic != null && !cardsState[pictureBoxList.IndexOf(pic)])
            {
                // Karta zosta�a klikni�ta i nie jest ju� odkryta
                string tag = pic.Tag.ToString();
                pic.Image = GetImage(tag);
                pic.BackColor = Color.White;
                cardsState[pictureBoxList.IndexOf(pic)] = true; // oznacz kart� jako odkryt�

                if (firstCard == null)
                {
                    firstCard = pic;
                }
                else
                {
                    if (firstCard.Tag.ToString() == tag)
                    {
                        // Odkryto dwie takie same karty
                    }
                    else
                    {
                        // Odkryto dwie r�ne karty
                        System.Threading.Thread.Sleep(1000); // Poczekaj chwil�, aby gracz zobaczy� drug� kart�
                        firstCard.BackColor = Color.LightGray;
                        firstCard.Image = null;
                        pic.BackColor = Color.LightGray;
                        pic.Image = null;
                        cardsState[pictureBoxList.IndexOf(firstCard)] = false; // zresetuj stan pierwszej karty
                        cardsState[pictureBoxList.IndexOf(pic)] = false; // zresetuj stan drugiej karty
                    }
                }
            }
        }

        private Image GetImage(string? tag)
        {
            switch (tag)
            {
                case "1":
                    return Properties.Resources.swinka1;
                case "2":
                    return Properties.Resources.swinka2;
                case "3":
                    return Properties.Resources.swinka3;
                case "4":
                    return Properties.Resources.swinka4;
                case "5":
                    return Properties.Resources.swinka5;
                case "6":
                    return Properties.Resources.swinka6;
                case "7":
                    return Properties.Resources.swinka7;
                case "8":
                    return Properties.Resources.swinka8;
            }
            return null;
        }

        private void AddPicturesToList()
        {
            pictureBoxList.Add(Picture1);
            pictureBoxList.Add(Picture2);
            pictureBoxList.Add(Picture3);
            pictureBoxList.Add(Picture4);
            pictureBoxList.Add(Picture5);
            pictureBoxList.Add(Picture6);
            pictureBoxList.Add(Picture7);
            pictureBoxList.Add(Picture8);
            pictureBoxList.Add(Picture9);
            pictureBoxList.Add(Picture10);
            pictureBoxList.Add(Picture11);
            pictureBoxList.Add(Picture12);
            pictureBoxList.Add(Picture13);
            pictureBoxList.Add(Picture14);
            pictureBoxList.Add(Picture15);
            pictureBoxList.Add(Picture16);

            Picture1.Tag = "1";
            Picture2.Tag = "1";
            Picture3.Tag = "2";
            Picture4.Tag = "2";
            Picture5.Tag = "3";
            Picture6.Tag = "3";
            Picture7.Tag = "4";
            Picture8.Tag = "4";
            Picture9.Tag = "5";
            Picture10.Tag = "5";
            Picture11.Tag = "6";
            Picture12.Tag = "6";
            Picture13.Tag = "7";
            Picture14.Tag = "7";
            Picture15.Tag = "8";
            Picture16.Tag = "8";
        }
    }
}

