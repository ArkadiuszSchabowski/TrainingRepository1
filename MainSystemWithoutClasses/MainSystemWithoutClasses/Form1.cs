using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MainSystemWithoutClasses
{
    public partial class Form1 : Form
    {
        public List<List<string>> litery = new List<List<string>>();
        public List<string> a = new List<string>();
        public List<string> b = new List<string>();
        public List<string> c = new List<string>();
        public List<string> d = new List<string>();

        public Form1()
        {
            InitializeComponent();
            DodajKontrahentowDoListy();
        }
        public void DodajKontrahentowDoListy()
        {
            a.Add("123");
            a.Add("456");

            litery.Add(a);
            litery.Add(b);
            litery.Add(c);
            litery.Add(d);

            foreach (var kolekcja in litery)
            {
                listBox2.Items.Add(GetNazwaKolekcji(kolekcja));
            }
        }
        public string GetNazwaKolekcji(List<string> kolekcja)
        {
            if (kolekcja == a)
                return "a";
            else if (kolekcja == b)
                return "b";
            else if (kolekcja == c)
                return "c";
            else if (kolekcja == d)
                return "d";
            else
                return string.Empty;
        }
        private void przyciskWyboru_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var ClickedValue = listBox2.SelectedItem;
                listBox2.Items.Clear();
                listBox2.Items.Add(ClickedValue);
            }

        }

    
    public void AddCountryToMainList()
    {
        AvailableOrders.Items.Add("Polska");
        AvailableOrders.Items.Add("Litwa");
        AvailableOrders.Items.Add("Wlochy");
    }
    private void TakeOrders_Click(object sender, EventArgs e)
    {
        if (!DowloadedOrders.Items.Contains(AvailableOrders.SelectedItem))
        {
            DowloadedOrders.Items.Add(AvailableOrders.SelectedItem);
        }
    }
    private void CancelOrders_Click(object sender, EventArgs e)
    {
        if (DowloadedOrders.SelectedItem != null)
        {
            DowloadedOrders.Items.RemoveAt(DowloadedOrders.SelectedIndex);
        }
    }
    private void DisplayContractors_Click(object sender, EventArgs e)
    {
    }
    public Random rnd = new Random();
    public List<string> orders = new List<string>();
    public void Brembo()
    {
        int bremboOrders = rnd.Next(1, 5);
        List<string> listBrembo = new List<string>()
        {
            "Klocki hamulcowe - MD19132",
            "Klocki hamulcowe - JG23145",
            "Zacisk hamulcowy - MD23142",
            "Tarcza hamulcowa - MD21902",
        };
        orders.Add(listBrembo[bremboOrders]);
    }
    public void Gkn()
    {
        List<string> listBrembo = new List<string>()
        {
            "Oslona przegubu - GKN2341",
                 "Oslona przegubu - GKN2389",
                 "Krzyzak walu napedowego - U-942",
                 "Smar do przegubow - 9043111"
            };
    }
    public void Rts()
    {
        List<string> listRts = new List<string>()
            {
                "Sworzen wahacza - 9140650",
                "Sworzen wahacza - 9300850",
                "Wahacz Renault lewy - 34817",
                "Wahacz Renault prawy - 34818"
            };
    }
    public void Snr()
    {
        List<string> listSnr = new List<string>()
            {
                "Lozysko amortyzatora Citroen",
                "Zestaw piasty kola tyl",
                "Lozysko piasty kola",
                "Lozysko kola Mazda 6 - przod",
            };
    }
}
}
