using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public class ContractorManager
    {
        public static void AddContractor(int idCounter, string contractorName, string country, string address, string phone, string email, string postCode, BindingList<ContractorInformation> list)
        {
            try
            {
                RandomGenerator random = new RandomGenerator();

                var newContractor = new ContractorInformation()
                {
                    ID = idCounter,
                    Contractor = contractorName,
                    Country = country,
                    Adress = address,
                    Phone = phone,
                    Email = email,
                    Post_Code = postCode,
                    Route = random.AddRouteNumberToTheContractor(country),
                    Bar_Code = random.AddBarCodeToTheContractor(),
                };
                list.Add(newContractor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
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