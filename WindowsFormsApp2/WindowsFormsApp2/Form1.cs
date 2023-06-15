using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using System.Drawing;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int _barCode;
        int countContractors = 0;
        BindingList<ContractorInformation> _list = new BindingList<ContractorInformation>();
        string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");

        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            CreateFile();

            GetData();

            CountContractors();

            dataGridView1.DataSource = _list;

            ChangeFontInDataGridViev();
            ChangeColumnWidths();
            ChangeColumnHeaders();
            HideBarCodeColumnWithDataGridView();
        }
        private void HideBarCodeColumnWithDataGridView()
        {
            dataGridView1.Columns["Kod_Kreskowy"].Visible = false;
        }
        private void ChangeColumnWidths()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            dataGridView1.Columns["Trasa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["Kontrahent"].Width = 180;
            dataGridView1.Columns["Kraj"].Width = 120;
            dataGridView1.Columns["Adres"].Width = 200;
            dataGridView1.Columns["Telefon"].Width = 150;
            dataGridView1.Columns["Email"].Width = 270;
            dataGridView1.Columns["Kod_Pocztowy"].Width = 140;
        }
        private void ChangeColumnHeaders()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold);
            }
        }

        private void ChangeFontInDataGridViev()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Verdana", 10);
            }
        }
        private void CountContractors()
        {
            try
            {
                lblCount.Text = $"Ilosc aktualnych kontrahentow: {countContractors}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveRecord();

                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string AddRouteNumberToTheContractor()
        {
            string route = "";
            string number = rnd.Next(1, 500).ToString();

            switch (cboCountry.Text.ToUpper())
            {
                case "POLSKA":
                    route = "P" + number;
                    break;
                case "LITWA":
                    route = "L" + number;
                    break;
                case "WLOCHY":
                    route = "W" + number;
                    break;
                case "CZECHY":
                    route = "C" + number;
                    break;
                case "NIEMCY":
                    route = "N" + number;
                    break;
                case "FRANCJA":
                    route = "F" + number;
                    break;
                default:
                    route = "0";
                    break;
            }

            tbRouteNumber.Text = route;
            return route;
        }
        private int AddBarCodeToTheContractor()
        {
            _barCode = rnd.Next(100000000, 999999999);
            return _barCode;
        }
        private void RemoveRecord()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetData()
        {
            try
            {
                var json = File.ReadAllText(_filePath);
                _list = JsonConvert.DeserializeObject<BindingList<ContractorInformation>>(json);

                if (json == null || !json.Any())
                {
                    _list = new BindingList<ContractorInformation>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    File.Create(_filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord();

            CountContractors();

            SaveData();

            ClearFields();
        }
        private void ClearFields()
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
        private void SaveData()
        {
            try
            {
                var json = JsonConvert.SerializeObject(_list);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddRecord()
        {
            try
            {
                var newContractor = new ContractorInformation()
                {
                    Kontrahent = tbContractor.Text,
                    Kraj = cboCountry.Text,
                    Adres = tbAdress.Text,
                    Telefon = tbPhone.Text,
                    Email = tbEmail.Text,
                    Kod_pocztowy = tbPostCode.Text,
                    Trasa = AddRouteNumberToTheContractor(),
                    Kod_Kreskowy = AddBarCodeToTheContractor(),
                };

                if (tbContractor.Text == string.Empty || cboCountry.Text == string.Empty || tbAdress.Text == string.Empty || tbPhone.Text == string.Empty || tbEmail.Text == string.Empty || tbPostCode.Text == string.Empty)
                {
                    DialogResult checkFields = MessageBox.Show("Przynajmniej jedno z pol jest puste. Czy chcesz dodac mimo tego?", "Ostrzezenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (checkFields == DialogResult.No)
                    {
                        return;
                    }
                }
                _list.Add(newContractor);
                countContractors++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit = MessageBox.Show("Czy na pewno chcesz wyjsc z aplikacji?", "Moto-Profil app", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
                if (iExit == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbContractor.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cboCountry.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbAdress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tbPostCode.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                //tbRouteNumber.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tbBarCode.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}