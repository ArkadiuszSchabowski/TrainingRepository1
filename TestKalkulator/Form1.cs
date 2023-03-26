namespace TestKalkulator
{
    public enum Operation
    {
        None,
        Addition,
        Substraction,
        Multiplication,
        Division,
    }
    public partial class Form1 : Form
    {

        private string _firstValue;
        private string _secondValue;
        private Operation _currentOperation = Operation.None;
        private bool _isResultOnTheScreen = false;

        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if(_isResultOnTheScreen != true)
            {
                SetBtnNumbersState(true);
            }

            if (tbScreen.Text == "0")
            {
                tbScreen.Text = string.Empty;
            }
            tbScreen.Text += clickedValue;

            if (_currentOperation != Operation.None)
            {
                _secondValue += clickedValue;
            }
            if (_currentOperation != Operation.None)
            {
                SetBtnOperationState(true);
            }
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;

            var operation = (sender as Button).Text;
            tbScreen.Text += $" {operation} ";

            _currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Substraction,
                "*" => Operation.Multiplication,
                "/" => Operation.Division,
                _ => Operation.None
            };
            if (_currentOperation != Operation.None)
            {
                SetBtnOperationState(false);
            }

        }
        private void OnBtnResultClick(object sender, EventArgs e)
        {

            double firstNumber = double.Parse(_firstValue);
            double secondNumber = double.Parse(_secondValue);

            double result = Calculate(firstNumber, secondNumber);

            tbScreen.Text = result.ToString();

            _isResultOnTheScreen = true;
            _secondValue = string.Empty;
            SetBtnOperationState(true);

            if (_isResultOnTheScreen)
            {
                SetBtnNumbersState(false);
                _isResultOnTheScreen = false;
            }
            if(_currentOperation != Operation.None)
            {
                SetBtnNumbersState(true);
            }
            _currentOperation = Operation.None;
        }
        public double Calculate(double firstNumber, double secondNumber)
        {
            switch (_currentOperation)
            {
                case Operation.None:
                    return firstNumber;
                case Operation.Addition:
                    return firstNumber + secondNumber;
                case Operation.Substraction:
                    return firstNumber - secondNumber;
                case Operation.Multiplication:
                    return firstNumber * secondNumber;
                case Operation.Division:
                    if(secondNumber == 0)
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez zero");
                    }
                    return firstNumber / secondNumber;
            }
            return 0;
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            tbScreen.Text = "0";
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            SetBtnOperationState(true);
            SetBtnNumbersState(true);
        }
        private void SetBtnOperationState(bool value)
        {
            BtnAddition.Enabled = value;
            BtnSubstraction.Enabled = value;
            BtnMultiplication.Enabled = value;
            BtnDivision.Enabled = value;
        }
        private void SetBtnResultState(bool value)
        {
            BtnResult.Enabled = value;
        }
        private void SetBtnNumbersState(bool value)
        {
            Btn1.Enabled = value;
            Btn2.Enabled = value;
            Btn3.Enabled = value;
            Btn4.Enabled = value;
            Btn4.Enabled = value;
            Btn5.Enabled = value;
            Btn6.Enabled = value;
            Btn7.Enabled = value;
            Btn8.Enabled = value;
            Btn9.Enabled = value;
            Btn0.Enabled = value;
            BtnComma.Enabled = value;
        }
    }
}