using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EnglishFlashcards
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

        int correct = 0;
        int incorrect = 0;

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
            CountWords();
            AddFewWordsToTheLists();
        }
        private void AllAnswers()
        {
            try
            {
                int sum = 0;
                int average = 0;

                sum = correct + incorrect;
                average = (correct * 100) / sum;

                lblCorrect.Text = $"Poprawnych odpowiedzi {correct}.";
                lblIncorrect.Text = $"Blednych odpowiedzi {incorrect}.";
                lblAverage.Text = $"Procent poprawnosci: {average}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CountWords()
        {
            try
            {

            }
            catch (Exception)
            {

            }
            lblCount.Text = "Ilosc fiszek w bazie danych: " + (dataGridView1.RowCount - 1);
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
            int rndIndex = rnd.Next(0, listEngland.Items.Count);
            string wylosowane = listEngland.Items[rndIndex].ToString();
            txtEngland.Text = wylosowane.ToString();
            txtPoland.Text = "";
        }
        private void AddFewWordsToTheLists()
        {
            listPoland.Items.Add("pies");
            listPoland.Items.Add("szczur");
            listPoland.Items.Add("gryzon");

            listEngland.Items.Add("dog");
            listEngland.Items.Add("rat");
            listEngland.Items.Add("rodent");
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

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {

            string polandWord = txtPoland.Text.ToLower();
            string englandWord = txtEngland.Text.ToLower();

            int index = listPoland.Items.IndexOf(polandWord);

            if (index != -1 && listEngland.Items.Count > index && listEngland.Items[index].ToString().ToLower() == englandWord)
            {
                MessageBox.Show("Poprawne słowo!");
                correct++;
                AllAnswers();

                txtPoland.Text = "";
                txtEngland.Text = "";
            }
            else
            {
                MessageBox.Show("Niepoprawne słowo!");
                incorrect++;
                AllAnswers();

                txtPoland.Text = "";
                txtEngland.Text = "";
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server=" + server + ";" + "username =" + user + ";" + "password =" + password + ";" + "database =" + database;
                sqlConn.Open();

                sqlQuery = "INSERT INTO englishflashcards VALUES('" + (txtNumber.Text + "','" + txtPolish.Text + "','" + txtEnglish.Text + "')").ToUpper();

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();

                string newFlashcard = txtNumber.Text + " - " + txtPolish.Text + " - " + txtEnglish.Text;
                listStageOne.Items.Add(newFlashcard);

                string poland = txtPolish.Text;
                string usa = txtEnglish.Text;

                listPoland.Items.Add(poland);
                listEngland.Items.Add(usa);

                txtNumber.Text = "";
                txtPolish.Text = "";
                txtEnglish.Text = "";
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


