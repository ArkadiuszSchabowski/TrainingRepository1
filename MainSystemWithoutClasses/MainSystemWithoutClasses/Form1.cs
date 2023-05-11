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
        public List<List<string>> polandContractors = new List<List<string>>();
        public List<string> autoSerwisKatowice = new List<string>();
        public List<string> warsztatSamochodowyCzteryKola = new List<string>();
        public List<string> magicznyGaraz = new List<string>();

        public Form1()
        {
            InitializeComponent();
            AddCountryToMainList();
            PolandContractors();
        }

        public void PolandContractors()
        {
            autoSerwisKatowice.Add("autoSerwisKatowice");
            warsztatSamochodowyCzteryKola.Add("warsztatSamochodowyCzteryKola");
            magicznyGaraz.Add("magicznyGaraz");

            polandContractors.Add(autoSerwisKatowice);
            polandContractors.Add(warsztatSamochodowyCzteryKola);
            polandContractors.Add(magicznyGaraz);

            foreach (var elem in polandContractors)
            {
                if (elem is List<string>)
                {
                    var list = elem as List<string>;

                        listBox1.Items.Add(list[0]);
                }
            }
        }
        private void WyswietlCzesciKontrahenta(object sender, EventArgs e)
        {

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
