using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateDisplay();
            AddCountry();
        }
        public void AddCountry()
        {
            countryList.Items.Add(Orders.Polska);
            countryList.Items.Add(Orders.Litwa);
            countryList.Items.Add(Orders.Wlochy);
        }

        private void UpdateDisplay()
        {
            contractorsList.DisplayMember = "Name";
            countryList.DisplayMember = "Country";
        }

        private void btnAddContractor_Click(object sender, EventArgs e)
        {
            contractorsList.Items.Add(new Contractor());
        }

        private void btnSaveInformation_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveContractor_Click(object sender, EventArgs e)
        {

        }
    }
}
