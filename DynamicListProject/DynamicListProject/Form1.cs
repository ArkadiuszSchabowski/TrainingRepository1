using DynamicListProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicListProject
{
    public partial class btnAdd : Form
    {
        BindingList<ContractorInformation> list = new BindingList<ContractorInformation>();
        Random rnd = new Random();
        string _barCode;

        public btnAdd()
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNewContractor();

            ClearFields();
        }

        private void ClearFields()
        {
            tbName.Text = "";
            cboCountry.Text = "";
            tbNumberRoute.Text = "";
            tbBarCode.Text = "";

            foreach (var item in panel1.Controls)
            {
            }
        }

        private void AddNewContractor()
        {
            string x = "A";
            string barCode = AddBarCodeToTheContractor(x);
            var newObject = new ContractorInformation()
            {
                Nazwa = tbName.Text,
                Kraj = cboCountry.Text,
                Trasa = tbNumberRoute.Text,
                Kod = barCode,
            };
            list.Add(newObject);
        }

        private string AddBarCodeToTheContractor(string x)
        {
            _barCode = rnd.Next(100000, 200000).ToString();
            return _barCode;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}