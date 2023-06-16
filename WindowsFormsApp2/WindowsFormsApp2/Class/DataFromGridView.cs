using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Class
{
    public static class DataFromGridView
    {
        public static void HideBarCodeColumnWithDataGridView()
        {
            dataGridView1.Columns["Kod_Kreskowy"].Visible = false;
        }
        public static void ChangeColumnHeaders()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold);
            }
        }
        public static void ChangeColumnWidths()
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

        public static void ChangeFontInDataGridViev()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Verdana", 10);
            }
        }
        public static void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
