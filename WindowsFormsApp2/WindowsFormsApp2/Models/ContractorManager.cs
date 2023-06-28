﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public class ContractorManager
    {

        public static void AddContractor(string contractorName, string country, string address, string phone, string email, string postCode, BindingList<ContractorInformation> _list)
        {
            try
            {
                RandomGenerator random = new RandomGenerator();

                var newContractor = new ContractorInformation()
                {
                    Kontrahent = contractorName,
                    Kraj = country,
                    Adres = address,
                    Telefon = phone,
                    Email = email,
                    Kod_pocztowy = postCode,
                    Trasa = random.AddRouteNumberToTheContractor(country),
                    Kod_Kreskowy = random.AddBarCodeToTheContractor(),
                };

                if (contractorName == string.Empty || country == string.Empty || address == string.Empty || phone == string.Empty || email == string.Empty || postCode == string.Empty)
                {
                    DialogResult checkFields = MessageBox.Show("Przynajmniej jedno z pól jest puste.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(newContractor.Kraj) || !ValidationHelper.IsValidCountry(newContractor.Kraj))
                {
                    MessageBox.Show("Wybierz poprawny kraj z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _list.Add(newContractor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RemoveContractor(DataGridView dataGridView1, ComboBox cboCountry, TextBox tbSearch, Panel panel2, BindingList<ContractorInformation> _list)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < _list.Count)
                    {
                        _list.RemoveAt(selectedRowIndex);
                        ClearContractors(cboCountry, tbSearch, panel2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ClearContractors(ComboBox cboCountry, TextBox tbSearch, Panel panel2)
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
