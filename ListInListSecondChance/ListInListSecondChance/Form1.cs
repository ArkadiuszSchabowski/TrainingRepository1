using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListInListSecondChance
{
    public partial class Form1 : Form
    {
        public List<string> CountryList = new List<string>();
        List<string> Polska = new List<string>();
        List<string> Italy = new List<string>();
        List<string> Hungary = new List<string>();
        public Form1()
        {
            InitializeComponent();
            AddCountry();
            AddContractors();
            AddCountryListToTheListBox1();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                listBox2.Items.Clear();
            }

            if (listBox1.SelectedIndex == 0)
            {
                foreach (var item in Polska)
                {
                    listBox2.Items.Add(item);
                }
            }

            if (listBox1.SelectedIndex == 1)
            {
                foreach (var item in Italy)
                {
                    listBox2.Items.Add(item);
                }
            }

            if (listBox1.SelectedIndex == 2)
            {
                foreach (var item in Hungary)
                {
                    listBox2.Items.Add(item);
                }
            }
        }
        public void AddCountry()
        {
            CountryList.Add("Poland");
            CountryList.Add("Italy");
            CountryList.Add("Hungary");
        }
        public void AddContractors()
        {
            Polska.Add("Magiczny garaz");
            Polska.Add("Cztery Kola");
            Polska.Add("Moto - tunning");

            Italy.Add("Maserrati Garage");
            Italy.Add("Pirelli Tires");
            Italy.Add("Ferrari Offical");

            Hungary.Add("Hungary Garage");
            Hungary.Add("Budapest race");
        }
        public void AddCountryListToTheListBox1()
        {
            foreach (var country in CountryList)
            {
                listBox1.Items.Add(country);
            }
        }

        private void btnAddListCountry_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nie podano kraju!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Istnieje juz taki kraj!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (textBox1.Text != "")
            {
                string lista = textBox1.Text;
                CountryList.Add(lista);
                listBox1.Items.Clear();
                AddCountryListToTheListBox1();
            }
        }
    }
}
