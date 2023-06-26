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
        int countContractors = 0;
        BindingList<ContractorInformation> _list = new BindingList<ContractorInformation>();
        string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");

        public Form1()
        {
            InitializeComponent();

            StrechTheWindowToFullScreen();

            DataAccess.CreateFile();

            DataAccess.GetData();

            dataGridView1.DataSource = _list;

            DataGridViewHelper.ChangeFontInDataGridViev();
            DataGridViewHelper.ChangeColumnWidths();
            DataGridViewHelper.ChangeColumnHeaders();
            DataGridViewHelper.HideBarCodeColumnWithDataGridView();
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
            ContractorManager.AddContractor(tbContractor.Text, cboCountry.Text, tbAdress.Text, tbPhone.Text, tbEmail.Text, tbPostCode.Text);

            DataAccess.SaveData();

            ContractorManager.ClearContractors();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void btnSort_Click(object sender, EventArgs e)
        {
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ContractorManager.RemoveContractor();

                DataAccess.SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ContractorManager.ClearContractors();
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