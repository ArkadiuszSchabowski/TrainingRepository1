using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    internal class DataGridViewHelper
    {
        public static void HideBarCodeColumnWithDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns["Kod_Kreskowy"].Visible = false;
        }
        public static void ChangeColumnHeaders(DataGridView dataGridView1)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridView1.Font.FontFamily, 12, FontStyle.Bold);
            }
        }
        public static void ChangeColumnWidths(DataGridView dataGridView1)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            dataGridView1.Columns["Trasa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["ID"].Width = 60;
            dataGridView1.Columns["Kontrahent"].Width = 180;
            dataGridView1.Columns["Kraj"].Width = 120;
            dataGridView1.Columns["Adres"].Width = 200;
            dataGridView1.Columns["Telefon"].Width = 150;
            dataGridView1.Columns["Email"].Width = 270;
            dataGridView1.Columns["Kod_Pocztowy"].Width = 140;
        }

        public static void ChangeFontInDataGridViev(DataGridView dataGridView1)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Verdana", 10);
            }
        }
        public static void SaveLastSelectedIndex(DataGridView dataGridView1)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    int lastRowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows[lastRowIndex].Selected = true;
                }
            }
        }
    }
}