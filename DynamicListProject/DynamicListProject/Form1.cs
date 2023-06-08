using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicListProject
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> CountryList = new Dictionary<string, List<string>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            try
            {
                string nameList = textBox1.Text.ToUpper();

                if (nameList == string.Empty)
                {
                    MessageBox.Show("Nie wpisano kraju", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (CountryList.ContainsKey(nameList))
                {
                    MessageBox.Show("Kraj juz istnieje", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (nameList != string.Empty && !CountryList.ContainsKey(nameList))
                {
                    List<string> country = new List<string>();
                    CountryList.Add(nameList, country);
                    listBox1.Items.Clear();
                    DisplayCountriesInListBoxOne();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayCountriesInListBoxOne()
        {
            foreach (string country in CountryList.Keys)
            {
                listBox1.Items.Add(country);
            }
        }

        private void btnAddContractor_Click(object sender, EventArgs e)
        {
            //Nad tym pracowac
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

        }
    }
}
