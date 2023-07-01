﻿using System;
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
        string idNumber = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "idCounter.txt");
        private int _idCounter;

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

            dataGridView1.AllowUserToAddRows = false;

            _idCounter = DataAccess.ReadIdCounterFromFile(idNumber);
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
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count) // Sprawdź, czy wiersz indeksu istnieje
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    tbID.Text = selectedRow.Cells[0].Value.ToString();
                    tbContractor.Text = selectedRow.Cells[1].Value.ToString();
                    cboCountry.Text = selectedRow.Cells[2].Value.ToString();
                    tbAdress.Text = selectedRow.Cells[3].Value.ToString();
                    tbPhone.Text = selectedRow.Cells[4].Value.ToString();
                    tbEmail.Text = selectedRow.Cells[5].Value.ToString();
                    tbPostCode.Text = selectedRow.Cells[6].Value.ToString();
                    tbRouteNumber.Text = selectedRow.Cells[7].Value.ToString();
                    tbBarCode.Text = selectedRow.Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string routeNumber = randomGenerator.AddRouteNumberToTheContractor(cboCountry.Text);

            DataAccess.SaveIdCounterToFile(idNumber);

            ContractorManager.AddContractor(tbContractor.Text, cboCountry.Text, tbAdress.Text, tbPhone.Text, tbEmail.Text, tbPostCode.Text, _list, _idCounter);

            _idCounter++;
            File.WriteAllText(idNumber, _idCounter.ToString());

            DataAccess.SaveData(_filePath, _list);

            ContractorManager.ClearContractors(cboCountry, tbSearch, panel2);

            dataGridView1.DataSource = _list;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Implement the Edit button functionality
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.ToLower();

            var searchResults = new BindingList<ContractorInformation>();

            foreach (var contractor in _list)
            {
                if (contractor.Kontrahent.ToLower().Contains(searchText) ||
                    contractor.Kraj.ToLower().Contains(searchText) ||
                    contractor.Adres.ToLower().Contains(searchText) ||
                    contractor.Telefon.ToLower().Contains(searchText) ||
                    contractor.Email.ToLower().Contains(searchText) ||
                    contractor.Kod_pocztowy.ToLower().Contains(searchText) ||
                    contractor.Trasa.ToLower().Contains(searchText))
                {
                    searchResults.Add(contractor);
                }
            }
            dataGridView1.DataSource = searchResults;
            tbSearch.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // TODO: Implement the Sort button functionality
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
