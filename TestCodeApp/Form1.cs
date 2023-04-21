using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCodeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Usuwamy wszystkie elementy z kontrolki
            listaProduktow.Items.Add("Cats");

            // Pobieramy wybraną kategorię z kontrolki lista
            string wybranaKategoria = listaProduktow.SelectedItem.ToString();

            // Pobieramy produkty związane z wybraną kategorią
            List<string> produkty = PobierzProduktyZKategorii(wybranaKategoria);

            // Dodajemy produkty do kontrolki listaProduktow
            foreach (string produkt in produkty)
            {
                listaProduktow.Items.Add(produkt);
            }
        }

        private List<string> PobierzProduktyZKategorii(string kategoria)
        {
            // Przykładowa implementacja pobierania produktów z wybranej kategorii
            if (kategoria == "Cats")
            {
                return new List<string> { "Karma dla kota", "Miska dla kota", "Drapak dla kota" };
            }
            else if (kategoria == "Dogs")
            {
                return new List<string> { "Karma dla psa", "Miska dla psa", "Kagańiec dla psa" };
            }
            else if (kategoria == "Guinea Piggs")
            {
                return new List<string> { "Karma dla świnki morskiej", "Miska dla świnki morskiej", "Klatka dla świnki morskiej" };
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
