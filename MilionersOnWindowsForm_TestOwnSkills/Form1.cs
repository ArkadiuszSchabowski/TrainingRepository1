using System.Windows.Forms;
using System;

namespace MilionersOnWindowsForm_TestOwnSkills
{
    public partial class Form1 : Form
    {
        public string[] _correctAnswers = new string[3];
        public string[] _questions = new string[3];
        public int accountBalance = 0;
        public int currentQuestionIndex = 0;

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            accountBalance = 0;
            currentQuestionIndex = 0;
            label1.Text = $"Your account balance is: {accountBalance}";
            AsignQuestions();
            DisplayQuestion(currentQuestionIndex);
        }

        public void DisplayQuestion(int questionIndex)
        {
            lblQuestion.Text = _questions[questionIndex];

            btnA.Text = "Biała";
            btnB.Text = "Czarna";
            btnC.Text = "Szara";
            btnD.Text = "Niebieska";
        }

        public void CheckAnswer(int questionIndex)
        {
            if (currentQuestionIndex == 0)
            {
                _correctAnswers[0] = "A";
            }

            if (currentQuestionIndex == 1)
            {
                _correctAnswers[1] = "B";
            }

            if (currentQuestionIndex == 2)
            {
                _correctAnswers[2] = "C";
            }
        }

        public void AsignQuestions()
        {
            _questions[0] = "Jakiego koloru jest Pepa?";
            _questions[1] = "Co jedzą świnki morskie, by ścierać zęby?";
            _questions[2] = "Jakie pojemność poidełka jest odpowiednia dla jednej świnki morskiej?";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            CheckAnswer(currentQuestionIndex);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            CheckAnswer(currentQuestionIndex);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CheckAnswer(currentQuestionIndex);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            CheckAnswer(currentQuestionIndex);
        }

        private void EndGame()
        {
            MessageBox.Show("Game Over! Your final account balance is: " + accountBalance);
        }
    }
}
