using Serializacja.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializacja
{
    public partial class Form1 : Form
    {
        private BindingList<Purchase> _purchases = new BindingList<Purchase>();
        public Form1()
        {
            InitializeComponent();
            dgvShopping.DataSource = _purchases;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var purchase = new Purchase
            {
                Amount = nudAmount.Value,
                Name = tbName.Text,
                CreatedDate = DateTime.UtcNow,
            };

            _purchases.Add(purchase);

            tbName.Text = "";
            nudAmount.Value = 0;
        }
    }
}
