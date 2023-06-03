using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter Dta = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "YES";
        String database = "membership";
        public Form1()
        {
            InitializeComponent();
        }
        private void uploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";"
                + "username =" + username + ";"
                + "password =" + password + ";"
                + "database =" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM membership.membership";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();

            dataGridView1.DataSource = sqlDt;

        }

        private void refNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(5000, 10000);
            txtBarCode.Text = "Additional Ref" + Convert.ToString(num * 12);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            refNumber();
            uploadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username =" + username + ";" + "password =" + password + ";" + "database =" + database;

                sqlConn.Open();

                sqlQuery = "INSERT INTO membership.membership (memid, firstname, surname, address, postcode, gender, mobile, email, mtype) VALUES('" + (txtMemberID.Text + "','" + txtFirstName.Text + "','" + txtSurname.Text + "','" + txtAdress.Text + "','" + txtPostCode.Text + "','" + cboGender.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + cboMemberType.Text + "')").ToUpper();

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                sqlConn.Close();
            }
            uploadData();
            refNumber();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMemberID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAdress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPostCode.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cboGender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtMobile.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cboMemberType.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = String.Format("firstname like '%{0}%'", txtSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username =" + username + ";" + "password =" + password + ";" + "database =" + database;

                sqlConn.Open();

                sqlCmd.CommandText = "DELETE FROM membership.membership WHERE memid =@memid";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
