using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public class ValidationHelper
    {
        public bool ValidateFields(string contractor, string adress, string phone, string email, string postCode)
        {
            if (string.IsNullOrEmpty(contractor) || string.IsNullOrEmpty(adress) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(postCode))
            {
                MessageBox.Show("Przynajmniej jedno z pól jest puste.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool ValidateContractorName(BindingList<ContractorInformation>_list, string contractor)
        {
            if (_list.Any(item => item.Kontrahent.ToLower() == contractor.ToLower()))
            {
                MessageBox.Show("Kontrahent o takiej nazwie już istnieje.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool ValidateCountry(string country, BindingList<ContractorInformation> list)
        {
            bool isValidCountry = list.Any(item => item.Kraj.ToLower() == country.ToLower());
            if (!isValidCountry)
            {
                MessageBox.Show("Wybierz poprawny kraj z listy.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}