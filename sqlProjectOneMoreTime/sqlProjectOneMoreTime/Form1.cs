using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlProjectOneMoreTime
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        MySqlDataAdapter sqlDta = new MySqlDataAdapter();

        String sqlQuery;
        MySqlDataReader rd;

        String server = "localhost";
        String user = "root";
        String password = "YES";
        String database = "membership";


        public Form1()
        {
            InitializeComponent();
            UploadData();
        }
        private void UploadData()
        {

            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;

                iExit = MessageBox.Show("Confirm if u gonna exit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
            try
            {
                foreach (Control item in panel3.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Text = "";
                    }
                }
                txtBarCode.Text = "";
                txtSearch.Text = "";
                cboGender.Text = "";
                cboMemberType.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
