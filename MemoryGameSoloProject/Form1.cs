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