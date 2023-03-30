using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//W grze Memory gracz musi odkrywaæ karty, które s¹ u³o¿one w losowej kolejnoœci na planszy, w celu znalezienia par takich samych kart. Jeœli gracz odgadnie parê, karty pozostaj¹ odkryte, a gracz zdobywa punkt. Jeœli gracz nie odgadnie pary, karty zostaj¹ zakryte i gracz musi spróbowaæ ponownie. Gra koñczy siê, gdy wszystkie pary zostan¹ odgadniête.

//W celu zaimplementowania tych zasad w kodzie, mo¿na rozpocz¹æ od dodania do ka¿dej karty (w postaci obiektu PictureBox) atrybutu "parê" lub "identyfikator" (np. karty 1-8, ka¿da z nich ma swojego "partnera" na planszy). Nastêpnie, mo¿na utworzyæ tablicê lub listê, która zawiera informacje o stanie ka¿dej karty (czy jest odkryta czy zakryta).

//Gdy gracz kliknie na kartê, nale¿y zmieniæ jej stan z zakrytej na odkryt¹, a nastêpnie porównaæ j¹ z innymi odkrytymi kartami w celu znalezienia pary. Jeœli odgadniêto parê, karty pozostaj¹ odkryte i gracz zdobywa punkt, jeœli nie, karty zostaj¹ zakryte i gra toczy siê dalej.

//Jeœli wszystkie pary zostan¹ odgadniête, gra koñczy siê, a gracz otrzymuje wynik. W tym momencie mo¿na daæ graczowi mo¿liwoœæ rozpoczêcia nowej gry lub zakoñczenia gry.

//Pamiêtaj, ¿e powy¿szy opis jest tylko wskazówk¹, a implementacja zasad gry Memory mo¿e wymagaæ dodatkowych kroków i modyfikacji w zale¿noœci od preferencji i potrzeb.
namespace MemoryGameSoloProject
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<PictureBox> pictureBoxList = new List<PictureBox>();
        bool[] cardsState = new bool[16]; // utworzenie tablicy przechowuj¹cej informacje o stanie ka¿dej karty
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
                cardsState[i] = false; // ustawienie stanu ka¿dej karty na zakryt¹ (false)
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
                // Karta zosta³a klikniêta i nie jest ju¿ odkryta
                string tag = pic.Tag.ToString();
                pic.Image = GetImage(tag);
                pic.BackColor = Color.White;
                cardsState[pictureBoxList.IndexOf(pic)] = true; // oznacz kartê jako odkryt¹

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
                        // Odkryto dwie ró¿ne karty
                        System.Threading.Thread.Sleep(1000); // Poczekaj chwilê, aby gracz zobaczy³ drug¹ kartê
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

