using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public class ValidationHelper
    {
        public static bool ValidateFields(string contractor, string adress, string phone, string email, string postCode)
        {
            if (string.IsNullOrEmpty(contractor) || string.IsNullOrEmpty(adress) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(postCode))
            {
                MessageBox.Show("At least one of the fields is empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool ValidateContractorName(BindingList<ContractorInformation> _list, string contractor)
        {
            if (_list.Any(item => item.Contractor.ToLower() == contractor.ToLower()))
            {
                MessageBox.Show("An contractor with that name already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public static bool ValidateCountry(ComboBox cboCountry, string country)
        {
            bool isValidCountry = cboCountry.Items.Contains(country);

            if (!isValidCountry)
            {
                MessageBox.Show("Please select the correct country from the list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}