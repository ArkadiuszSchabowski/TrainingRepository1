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

namespace SQLProject
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable dt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter Dta = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "12345";
        String database = "membership";
        public Form1()
        {
            InitializeComponent();
        }
        private void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "username" + username + ";" + "password " + password + ";" + "database" + database;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;

                iExit = MessageBox.Show("Do you want close this aplication?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
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
                foreach (Control c in panel3.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Clear();
                    }
                }
                txtBarCode.Clear();
                txtSearch.Clear();
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
