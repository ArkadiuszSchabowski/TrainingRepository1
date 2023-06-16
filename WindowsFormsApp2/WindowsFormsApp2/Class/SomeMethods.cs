using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Class
{
    public static class SomeMethods
    {
        public static void AddRecord()
        {
            try
            {
                var newContractor = new ContractorInformation()
                {
                    Kontrahent = tbContractor.Text,
                    Kraj = cboCountry.Text,
                    Adres = tbAdress.Text,
                    Telefon = tbPhone.Text,
                    Email = tbEmail.Text,
                    Kod_pocztowy = tbPostCode.Text,
                    Trasa = AddRouteNumberToTheContractor(),
                    Kod_Kreskowy = AddBarCodeToTheContractor(),
                };

                if (tbContractor.Text == string.Empty || cboCountry.Text == string.Empty || tbAdress.Text == string.Empty || tbPhone.Text == string.Empty || tbEmail.Text == string.Empty || tbPostCode.Text == string.Empty)
                {
                    DialogResult checkFields = MessageBox.Show("Przynajmniej jedno z pol jest puste. Czy chcesz dodac mimo tego?", "Ostrzezenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (checkFields == DialogResult.No)
                    {
                        return;
                    }
                }
                _list.Add(newContractor);
                countContractors++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string AddRouteNumberToTheContractor()
        {
            string route = "";
            string number = rnd.Next(1, 500).ToString();
            string selectedCountry = cboCountry.Text;

            switch (selectedCountry)
            {
                case "Polska":
                    route = "P" + number;
                    break;
                case "Litwa":
                    route = "L" + number;
                    break;
                case "Wlochy":
                    route = "W" + number;
                    break;
                case "Czechy":
                    route = "C" + number;
                    break;
                case "Niemcy":
                    route = "N" + number;
                    break;
                case "Francja":
                    route = "F" + number;
                    break;
                default:
                    route = "0";
                    break;
            }
            tbRouteNumber.Text = route;
            return route;
        }
        private static int AddBarCodeToTheContractor()
        {
            _barCode = rnd.Next(100000000, 999999999);
            return _barCode;
        }

        public static void RemoveRecord()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < _list.Count)
                    {
                        _list.RemoveAt(selectedRowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ClearFields()
        {
            try
            {
                foreach (Control item in panel2.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }
                cboCountry.Text = "";
                tbSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
