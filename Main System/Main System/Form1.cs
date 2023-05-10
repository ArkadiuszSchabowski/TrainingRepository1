using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_System
{
    public partial class Form1 : Form
    {
        List<string> orders = new List<string>()
        {
            "Polska", "Litwa", "Wlochy"
        };
        public Form1()
        {
            InitializeComponent();
            AddCountryToMainList();
        }

        public void AddCountryToMainList()
        {
            AvailableOrders.Items.Add("Polska");
            AvailableOrders.Items.Add("Litwa");
            AvailableOrders.Items.Add("Wlochy");
        }
    }
}
