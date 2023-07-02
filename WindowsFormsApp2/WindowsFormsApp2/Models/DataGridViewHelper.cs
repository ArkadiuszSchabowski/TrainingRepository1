using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    internal class DataGridViewHelper
    {
        public static void HideBarCodeColumnWithDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns["Bar_Code"].Visible = false;
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
            dataGridView1.Columns["Route"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["ID"].Width = 60;
            dataGridView1.Columns["Contractor"].Width = 180;
            dataGridView1.Columns["Country"].Width = 120;
            dataGridView1.Columns["Adress"].Width = 200;
            dataGridView1.Columns["Phone"].Width = 150;
            dataGridView1.Columns["Email"].Width = 270;
            dataGridView1.Columns["Post_Code"].Width = 140;
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