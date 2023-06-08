using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicList
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> CountryList = new Dictionary<string, List<string>>();
        List<string> Poland = new List<string>();
        List<string> Italy = new List<string>();

        public Form1()
        {
            InitializeComponent();
            AddCountryToTheCountryList();
            AddContractorToTheCountry();
            AddCountryListToTheListBoxOne();
        }
        public void AddCountryToTheCountryList()
        {
            CountryList.Add("Poland", Poland);
            CountryList.Add("Italy", Italy);
        }
        public void AddContractorToTheCountry()
        {
            Poland.Add("Cztery Kola");
        }
        public void AddCountryListToTheListBoxOne()
        {
            try
            {
                foreach (var item in CountryList.Keys)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string newListName = textBox1.Text.ToUpper();
                List<string> newContractorList = new List<string>();

                if (newListName == "")
                {
                    MessageBox.Show("Nie podano nazwy kraju", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (CountryList.ContainsKey(newListName))
                {
                    MessageBox.Show("Istnieje juz taki kraj", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (newListName != null && !CountryList.ContainsKey(newListName))
                {
                    CountryList.Add(newListName, newContractorList);
                }
                listBox1.Items.Clear();
                AddCountryListToTheListBoxOne();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddContractor_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedCountry = listBox1.SelectedItem.ToString();
                string contractorName = textBox2.Text;

                if (!string.IsNullOrEmpty(contractorName))
                {
                    if (CountryList.ContainsKey(selectedCountry))
                    {
                        List<string> contractors = CountryList[selectedCountry];
                        contractors.Add(contractorName);
                        listBox2.Items.Clear();
                        listBox2.Items.AddRange(contractors.ToArray());
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Nie podano nazwy kontrahenta", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedCountry = listBox1.SelectedItem.ToString();

                if (CountryList.ContainsKey(selectedCountry))
                {
                    List<string> contractors = CountryList[selectedCountry];
                    listBox2.Items.Clear();
                    listBox2.Items.AddRange(contractors.ToArray());
                }
            }
        }
    }
}
