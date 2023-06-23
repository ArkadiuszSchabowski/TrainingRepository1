using MotoProfilProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MotoProfilProject
{
    public partial class MotoApp : Form
    {
        Random rnd = new Random();
        BindingList<ContractorInformation> _list = new BindingList<ContractorInformation>();
        public string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");
        public MotoApp()
        {
            InitializeComponent();

            StrechTheWindowToFullScreen();

            CreateFile();
            GetData();

            dataGridView1.DataSource = _list;

            HideBarCodeColumnWithDataGridView();
            ChangeColumnWidths();
            ChangeColumnHeaders();
            ChangeFontInDataGridViev();
        }
        //FullSize
        private void StrechTheWindowToFullScreen()
        {
            WindowState = FormWindowState.Maximized;
        }
        //DataGridView
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
                tbBarCode.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tbRouteNumber.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //Serialize and deserialize

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

        //Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewContractor();

            SaveData();
        }

        private void AddNewContractor()
        {
            var contractor = new ContractorInformation()
            {
                Kontrahent = tbContractor.Text,
                Kraj = cboCountry.Text,
                Adres = tbAdress.Text,
                Telefon = tbPhone.Text,
                Email = tbEmail.Text,
                Kod_Pocztowy = tbPostCode.Text,
                Kod_Kreskowy = AddBarCodeToTheContractor(),
                Trasa = AddRouteNumberToTheContractor(),
            };
            _list.Add(contractor);
            ClearFields();
        }

        private string AddRouteNumberToTheContractor()
        {
            return tbRouteNumber.Text;
        }

        private int AddBarCodeToTheContractor()
        {
            var barCode = rnd.Next(1000000, 9999999);
            return barCode;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = "";
                }
            }
            cboCountry.Text = "";
            tbRouteNumber.Text = "";
            tbBarCode.Text = "";
            tbSearch.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść z aplikacji?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (result == DialogResult.No)
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
