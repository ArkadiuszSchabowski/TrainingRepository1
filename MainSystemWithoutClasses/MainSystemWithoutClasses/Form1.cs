using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystemWithoutClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddCountryToMainList();
        }

        public void AddCountryToMainList()
        {
            AvailableOrders.Items.Add("Polska", false);
            AvailableOrders.Items.Add("Litwa", false);
            AvailableOrders.Items.Add("Wlochy", false);
        }

        private void TakeOrders_Click(object sender, EventArgs e)
        {
            if (!DowloadedOrders.Items.Contains(AvailableOrders.SelectedItem))
            {
                DowloadedOrders.Items.Add(AvailableOrders.SelectedItem);
            }
        }
        private void CancelOrders_Click(object sender, EventArgs e)
        {
            if (DowloadedOrders.SelectedItem != null)
            {
                DowloadedOrders.Items.RemoveAt(DowloadedOrders.SelectedIndex);
            }
        }
        private void DisplayContractors_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add()
        }
    }
}
