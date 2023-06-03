using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EnglishFlashCardProject
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
        String database = "englishflashcards";
        public Form1()
        {
            InitializeComponent();
            UploadData();
            CountFishes();
        }
        public void CountFishes()
        {
            LabelCount.Text = "Fiszek w bazie danych: " + (dataGridView1.RowCount -2).ToString();
        }
        public void UploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";"
                  + "username =" + username + ";"
                  + "password =" + password + ";"
                  + "database =" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM englishflashcards.englishflashcards ORDER BY NR DESC";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();

            dataGridView1.DataSource = sqlDt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username =" + username + ";" + "password =" + password + ";" + "database =" + database;
                sqlConn.Open();

                sqlQuery = "INSERT INTO englishflashcards.englishflashcards (NR, PL, ENG) VALUES('" + (textNumber.Text +"','" + textPolish.Text + "','" + textEnglish.Text  + "')").ToUpper();

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
            UploadData();
            CountFishes();
        }
    }
}
