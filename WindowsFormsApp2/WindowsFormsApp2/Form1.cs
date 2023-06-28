using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        RandomGenerator randomGenerator = new RandomGenerator();

        BindingList<ContractorInformation> _list = new BindingList<ContractorInformation>();
        string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");

        public Form1()
        {
            InitializeComponent();

            StrechTheWindowToFullScreen();

            DataAccess.CreateFile(_filePath);

            DataAccess.GetData(_filePath, _list);

            dataGridView1.DataSource = _list;

            DataGridViewHelper.ChangeFontInDataGridViev(dataGridView1);
            DataGridViewHelper.ChangeColumnWidths(dataGridView1);
            DataGridViewHelper.ChangeColumnHeaders(dataGridView1);
            DataGridViewHelper.HideBarCodeColumnWithDataGridView(dataGridView1);
        }

        //Set windows property

        private void StrechTheWindowToFullScreen()
        {
            WindowState = FormWindowState.Maximized;
        }

        //Buttons

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
                tbRouteNumber.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tbBarCode.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string routeNumber = randomGenerator.AddRouteNumberToTheContractor(cboCountry.Text);
            ContractorManager.AddContractor(tbContractor.Text, cboCountry.Text, tbAdress.Text, tbPhone.Text, tbEmail.Text, tbPostCode.Text, _list);


            DataAccess.SaveData(_filePath, _list);

            ContractorManager.ClearContractors(cboCountry, tbSearch, panel2);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void btnSort_Click(object sender, EventArgs e)
        {
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ContractorManager.RemoveContractor(dataGridView1, cboCountry, tbSearch, panel2, _list);

                DataAccess.SaveData(_filePath, _list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ContractorManager.ClearContractors(cboCountry, tbSearch, panel2);
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

    }
}