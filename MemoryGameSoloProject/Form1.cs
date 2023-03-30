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
        ListBox lista = new ListBox();
        bool[] tablica = new bool[16];

        public Form1()
        {
            InitializeComponent();
            AddPictureToTheList();
        }

        public void AddPictureToTheList()
        {
            lista.Items.Add(Picture1);
            lista.Items.Add(Picture2);
            lista.Items.Add(Picture3);
            lista.Items.Add(Picture4);
            lista.Items.Add(Picture5);
            lista.Items.Add(Picture6);
            lista.Items.Add(Picture7);
            lista.Items.Add(Picture8);
            lista.Items.Add(Picture9);
            lista.Items.Add(Picture10);
            lista.Items.Add(Picture11);
            lista.Items.Add(Picture12);
            lista.Items.Add(Picture13);
            lista.Items.Add(Picture14);
            lista.Items.Add(Picture15);
            lista.Items.Add(Picture16);
        }
    }
}