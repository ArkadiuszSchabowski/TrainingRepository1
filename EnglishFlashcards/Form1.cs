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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EnglishFlashcards
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        MySqlDataAdapter sqlDta = new MySqlDataAdapter();

        String sqlQuery;
        MySqlDataReader sqlRd;

        DataSet ds = new DataSet();

        string server = "localhost";
        string user = "root";
        string password = "YES";
        string database = "englishflashcards";



        public Form1()
        {
            InitializeComponent();
            UploadData();
            AddFewWordsToTheLists();
        }
        private void btnRandomPl_Click(object sender, EventArgs e)
        {
            int rndIndex = rnd.Next(0, listPoland.Items.Count);
            string wylosowane = listPoland.Items[rndIndex].ToString();
            txtPoland.Text = wylosowane.ToString();
            txtEngland.Text = "";
        }
        private void btnRandomEng_Click(object sender, EventArgs e)
        {
            int rndIndex = rnd.Next(0, listUsa.Items.Count);
            string wylosowane = listUsa.Items[rndIndex].ToString();
            txtEngland.Text = wylosowane.ToString();
            txtPoland.Text = "";
        }
        private void AddFewWordsToTheLists()
        {
            listPoland.Items.Add("Pies");
            listPoland.Items.Add("Szczur");
            listPoland.Items.Add("Gryzon");

            listUsa.Items.Add("Dog");
            listUsa.Items.Add("Rat");
            listUsa.Items.Add("Rodent");
        }

        private void UploadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";"
                + "username =" + user + ";"
                + "password =" + password + ";"
                + "database =" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM englishflashcards";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();

            dataGridView1.DataSource = sqlDt;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dzieki projektowi English Flashcards nauczysz sie slownictwa angielskiego. Jesli poprawnie wpiszesz slowo zostanie ono dodane do nastepnego pudelka .Pudelek jest piec. Jesli fiszka trafi do ostatniego pudelka zostanie uznana jako zaliczona. Jesli bedziesz miala taka potrzebe mozesz przerzucic ja ponownie na poczatek.Powodzenia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username =" + user + ";" + "password =" + password + ";" + "database =" + database;
                sqlConn.Open();

                sqlQuery = "INSERT INTO englishflashcards VALUES('" + (textNumber.Text + "','" + textPolish.Text + "','" + textEnglish.Text + "')").ToUpper();

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();

                string newFlashcard = textNumber.Text + " - " + textPolish.Text + " - " + textEnglish.Text;
                listStageOne.Items.Add(newFlashcard);

                string poland = textPolish.Text;
                string usa = textEnglish.Text;

                listPoland.Items.Add(poland);
                listUsa.Items.Add(usa);

                textNumber.Text = "";
                textPolish.Text = "";
                textEnglish.Text = "";
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
        }
    }
}
