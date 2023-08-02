using System.Windows.Forms;
using System;

namespace MilionersOnWindowsForm_TestOwnSkills
{
    public partial class Form1 : Form
    {
        string _userChoice;
        int _accountBalance = 0;
        string[] _arrayQuestions = new string[3];
        int _currentQuestion = 0;
        public Form1()
        {
            InitializeComponent();
            AssignAccountBalanceToUser();
            AssignQuestionsToArray();
            DisplayQuestions(_currentQuestion);
        }
        private void AssignAccountBalanceToUser()
        {
            lblAccountBalance.Text = _accountBalance.ToString();
        }
        private void AssignQuestionsToArray()
        {
            _arrayQuestions[0] = "Jakiego koloru jest świnka Pepa?";
            _arrayQuestions[1] = "Co jedzą świnki, by ścierać zęby?";
            _arrayQuestions[2] = "Jakie jest prawidłowe poidełko dla jednej świnki morskiej?";
        }

        private void AssignButtonsToQuestion(int currentQuestion)
        {
            switch (_currentQuestion)
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
            if (_currentQuestion < _arrayQuestions.Length)
            {
                lblQuestion.Text = _arrayQuestions[_currentQuestion];
                AssignButtonsToQuestion(_currentQuestion);
            }
        }

        private void CheckAnswer(string userChoice)
        {
            if (_currentQuestion == 0)
            {
                if (_userChoice == "A.Biała")
                {
                    _userChoice = "";
                    _currentQuestion++;
                    _accountBalance += 100;
                    AssignAccountBalanceToUser();

                    DisplayQuestions(_currentQuestion);
                    AssignButtonsToQuestion(_currentQuestion);

                    return;
                }
                else if (_userChoice == "B.Różowa" || _userChoice == "C.Szara" || _userChoice == "D.Czarna")
                {
                    MessageBox.Show("Dziękujemy za grę otrzymujesz nagrodę pocieszenia\nŚwiński kubek jest Twój!");
                    EndGame();
                    return;
                }
            }

            if (_currentQuestion == 1)
            {

                if (_userChoice == "B.Siano")
                {
                    _userChoice = "";
                    lblQuestion.Text = _arrayQuestions[1];
                    _accountBalance += 100;
                    _currentQuestion++;
                    DisplayQuestions(_currentQuestion);
                    AssignButtonsToQuestion(_currentQuestion);
                    return;
                }
                else if (_userChoice == "A.Sałatę rzymską" || _userChoice == "C.Banana" || _userChoice == "D.Pomidora")
                {
                    MessageBox.Show("Dziękujemy za grę otrzymujesz nagrodę pocieszenia\nŚwiński kubek jest Twój!");
                    EndGame();
                    return;
                }
            }
            if (_currentQuestion == 2)
            {

                if (_userChoice == "D.250ml lub większe")
                {
                    //_userChoice = "";
                    //lblQuestion.Text = _arrayQuestions[1];
                    //_currentQuestion++;
                    //DisplayQuestions(_currentQuestion);
                    //AssignButtonsToQuestion(_currentQuestion);

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
