using System;
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

        public static void AddContractor(string contractorName, string country, string address, string phone, string email, string postCode)
        {
            try
            {
                var newContractor = new ContractorInformation()
                {
                    Kontrahent = contractorName,
                    Kraj = country,
                    Adres = address,
                    Telefon = phone,
                    Email = email,
                    Kod_pocztowy = postCode,
                    Trasa = AddRouteNumberToTheContractor(),
                    Kod_Kreskowy = AddBarCodeToTheContractor(),
                };

                if (contractorName == string.Empty || country == string.Empty || address == string.Empty || phone == string.Empty || email == string.Empty || postCode == string.Empty)
                {
                    DialogResult checkFields = MessageBox.Show("Przynajmniej jedno z pól jest puste.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(newContractor.Kraj) || !IsValidCountry(newContractor.Kraj))
                {
                    MessageBox.Show("Wybierz poprawny kraj z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _list.Add(newContractor);
                countContractors++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RemoveContractor()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < _list.Count)
                    {
                        _list.RemoveAt(selectedRowIndex);
                        ClearContractors();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ClearContractors()
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
