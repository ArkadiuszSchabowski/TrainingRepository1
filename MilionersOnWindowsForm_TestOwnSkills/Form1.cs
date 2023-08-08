using System.Windows.Forms;
using System;

namespace MilionersOnWindowsForm_TestOwnSkills
{
    public partial class Form1 : Form
    {
        string _userChoice;
        int _accountBalance = 0;
        string[] _arrayQuestions = new string[3];
        int _question;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            AssignAccountBalanceToUser();
            _question = RandomQuestion();
            QuestionsFor100.DisplaySelectedQuestion(_arrayQuestions, _question);
            DisplayQuestions(_question);
        }
        private void AssignAccountBalanceToUser()
        {
            lblAccountBalance.Text = _accountBalance.ToString();
        }
        public int RandomQuestion()
        {
            int quest = rnd.Next(1, 3);
            return quest;
        }

        private void AssignAnswersToButtons(int currentQuestion)
        {
            switch (_question)
            {
                case 0:
                    btnA.Text = "A.Biała";
                    btnB.Text = "B.Różowa";
                    btnC.Text = "C.Szara";
                    btnD.Text = "D.Czarna";
                    break;
                case 1:
                    btnA.Text = "A.Sałatę rzymską";
                    btnB.Text = "B.Siano";
                    btnC.Text = "C.Banana";
                    btnD.Text = "D.Pomidora";
                    break;
                case 2:
                    btnA.Text = "A.125ml lub mniejsze";
                    btnB.Text = "B.200ml";
                    btnC.Text = "C.225ml";
                    btnD.Text = "D.250ml lub większe";
                    break;
            }
        }

        private void DisplayQuestions(int currentQuestion)
        {
            QuestionsFor100.DisplaySelectedQuestion(_arrayQuestions, _question);

            if (_question < _arrayQuestions.Length)
            {
                lblQuestion.Text = _arrayQuestions[_question];
                AssignAnswersToButtons(_question);
            }
        }

        private void CheckAnswer(string userChoice)
        {
            if (_question == 0)
            {
                if (_userChoice == "A.Biała")
                {
                    _userChoice = "";
                    _accountBalance += 100;
                    AssignAccountBalanceToUser();

                    DisplayQuestions(_question);
                    AssignAnswersToButtons(_question);

                    return;
                }
                else if (_userChoice == "B.Różowa" || _userChoice == "C.Szara" || _userChoice == "D.Czarna")
                {
                    MessageBox.Show("Dziękujemy za grę otrzymujesz nagrodę pocieszenia\nŚwiński kubek jest Twój!");
                    EndGame();
                    return;
                }
            }

            if (_question == 1)
            {

                if (_userChoice == "B.Siano")
                {
                    _userChoice = "";
                    lblQuestion.Text = _arrayQuestions[1];
                    _accountBalance += 100;
                    DisplayQuestions(_question);
                    AssignAnswersToButtons(_question);
                    return;
                }
                else if (_userChoice == "A.Sałatę rzymską" || _userChoice == "C.Banana" || _userChoice == "D.Pomidora")
                {
                    MessageBox.Show("Dziękujemy za grę otrzymujesz nagrodę pocieszenia\nŚwiński kubek jest Twój!");
                    EndGame();
                    return;
                }
            }
            if (_question == 2)
            {

                if (_userChoice == "D.250ml lub większe")
                {
                    _userChoice = "";
                    lblQuestion.Text = _arrayQuestions[1];
                    _question++;
                    DisplayQuestions(_question);
                    AssignAnswersToButtons(_question);

                    _accountBalance += 100;
                    MessageBox.Show($"Congrats! You win a {_accountBalance}$!");
                    EndGame();

                }
                else if (_userChoice == "A.125ml lub mniejsze" || _userChoice == "B.200ml" || _userChoice == "C.225ml")
                {
                    MessageBox.Show("Dziękujemy za grę otrzymujesz nagrodę pocieszenia\nŚwiński kubek jest Twój!");
                    EndGame();
                }
            }
        }

        private void EndGame()
        {
            Close();
        }


        private void btnA_Click(object sender, EventArgs e)
        {
            _userChoice = (sender as Button).Text;
            CheckAnswer(_userChoice);
        }


        private void btnB_Click(object sender, EventArgs e)
        {
            _userChoice = (sender as Button).Text;
            CheckAnswer(_userChoice);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            _userChoice = (sender as Button).Text;
            CheckAnswer(_userChoice);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            _userChoice = (sender as Button).Text;
            CheckAnswer(_userChoice);
        }
    }
}
