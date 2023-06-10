using DynamicListProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicListProject
{
    public partial class btnAdd : Form
    {
        BindingList<ContractorInformation> _list = new BindingList<ContractorInformation>();
        Random rnd = new Random();
        string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");
        string _barCode;

        public btnAdd()
        {
            InitializeComponent();

            CreateData();

            GetData();

            dataGridView1.DataSource = _list;
        }

        private void GetData()
        {
            var json = File.ReadAllText(_filePath);
            _list = JsonConvert.DeserializeObject<BindingList<ContractorInformation>>(json);

            if (_list == null || !_list.Any())
            {
                _list = new BindingList<ContractorInformation>();
            }
        }

        private void CreateData()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNewContractor();

            SaveData();

            ClearFields();
        }

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(_list);
            File.WriteAllText(_filePath, json);
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
            _list.Add(newObject);
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