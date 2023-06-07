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
                return;
            }

            if (listBox1.SelectedIndex == 0)
            {
                foreach (var item in Polska)
                {
                    listBox2.Items.Add(item);
                }
                return;
            }

            if (listBox1.SelectedIndex == 1)
            {
                foreach (var item in Italy)
                {
                    listBox2.Items.Add(item);
                }
                return;
            }

            if (listBox1.SelectedIndex == 2)
            {
                foreach (var item in Hungary)
                {
                    listBox2.Items.Add(item);
                }
                return;
            }
        }
        public void AddCountry()
        {
            CountryList.Add("POLAND");
            CountryList.Add("ITALY");
            CountryList.Add("HUNGARY");
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
            string newContractor = textBox1.Text.ToUpper();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Nie podano kraju!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (listBox1.Items.Contains(newContractor))
            {
                MessageBox.Show("Istnieje juz taki kraj!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox1.Text != "" && !listBox1.Items.Contains(newContractor))
            {
                CountryList.Add(newContractor);
                listBox1.Items.Clear();
                AddCountryListToTheListBox1();
                return;
            }
        }

        private void btnAddContractor_Click(object sender, EventArgs e)
        {
            List<string> SelectedCountry = list<string> listBox1.SelectedItem;

            if (listBox1.SelectedItem == null)
            {
                return;
            }
            else
            {
                listBox2.Items.Add(textBox2.Text);
                return;
            }
        }
    }
}
