using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string _barCode;
        int countContractors = 0;
        BindingList<ContractorInformation> _list = new BindingList<ContractorInformation>();
        string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");

        public Form1()
        {
            InitializeComponent();

            CreateFile();

            GetData();

            CountContractors();

            dataGridView1.DataSource = _list;

        }

        private void CountContractors()
        {
            countContractors = dataGridView1.RowCount;

            lblCount.Text = $"Ilosc aktualnych kontrahentow: {countContractors}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveRecord();

            SaveData();
        }
        private void AddRouteNumberToTheContractor()
        {
            string routeNumber = tbRouteNumber.Text;

            switch (routeNumber)
            {
                case "POLSKA":
                    tbRouteNumber.Text = "A";
                    break;
                case "LITWA":
                    tbRouteNumber.Text = "A";
                    break;
                case "WLOCHY":
                    tbRouteNumber.Text = "A";
                    break;
                case "CZECHY":
                    tbRouteNumber.Text = "A";
                    break;
                case "NIEMCY":
                    tbRouteNumber.Text = "A";
                    break;
                case "FRANCJA":
                    tbRouteNumber.Text = "A";
                    break;
                default:
                    break;
            }
        }
        private void AddBarCodeToTheContractor()
        {
            _barCode = rnd.Next(100000, 200000).ToString();
        }

        private void RemoveRecord()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedRowIndex >= 0 && selectedRowIndex < _list.Count)
                {
                    _list.RemoveAt(selectedRowIndex);
                }
            }
        }

        private void GetData()
        {
            var json = File.ReadAllText(_filePath);
            _list = JsonConvert.DeserializeObject<BindingList<ContractorInformation>>(json);

            if (json == null || !json.Any())
            {
                _list = new BindingList<ContractorInformation>();
            }
        }

        private void CreateFile()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord();

            SaveData();

            ClearFields();

        }

        private void ClearFields()
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

        private void SaveData()
        {
            var json = JsonConvert.SerializeObject(_list);
            File.WriteAllText(_filePath, json);
        }

        private void AddRecord()
        {

            var whoBorrow = new ContractorInformation()
            {
                Kraj = tbContractor.Text,
                Kontrahent = cboCountry.Text
            };

            whoBorrow.Kod_Kreskowy = _barCode;

            _list.Add(whoBorrow);

            tbBarCode.Text = _barCode;

            AddBarCodeToTheContractor();

            AddRouteNumberToTheContractor();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
