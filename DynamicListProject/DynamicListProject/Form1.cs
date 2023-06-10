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
        BindingList<ContractorInformation> lista = new BindingList<ContractorInformation>();
        Random rnd = new Random();
        string _barCode;

        public btnAdd()
        {
            InitializeComponent();
            dataGridView1.DataSource = lista;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string x = "A";
            string barCode = AddBarCodeToTheContractor(x);
            var newObject = new ContractorInformation()
            {
                Nazwa = tbName.Text,
                Kraj = cmbCountry.Text,
                Trasa = tbNumberRoute.Text,
                Kod = barCode,
            };
            lista.Add(newObject);
        }

        private string AddBarCodeToTheContractor(string x)
        {
            _barCode = rnd.Next(100000, 200000).ToString();
            return _barCode;
        }
    }
}