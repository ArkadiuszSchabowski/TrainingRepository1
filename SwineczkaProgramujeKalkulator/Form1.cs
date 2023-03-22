namespace SwineczkaProgramujeKalkulator
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
        private bool _isTheResultOnTheScreen;

        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {

            var clickedValue = (sender as Button).Text;

            if (tbScreen.Text == "0" && clickedValue != ",")
                tbScreen.Text = string.Empty;

            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;
                tbScreen.Text = string.Empty;
            }

            if (clickedValue == "0")
            {
                if (clickedValue == ",")
                {
                    clickedValue = "0,";
                }
            }

            tbScreen.Text += clickedValue;
            SetResultBtnState(true);

            if (_currentOperation != Operation.None)
                _secondValue += clickedValue;
            else
            SetOperationBtnState(true);

        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;

            var operation = (sender as Button).Text;

            _currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Substraction,
                "*" => Operation.Multiplication,
                "/" => Operation.Division,
                _ => Operation.None,
            };
            tbScreen.Text += $" {operation} ";

            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;
                tbScreen.Text = string.Empty;
            }

            SetOperationBtnState(false);
            SetResultBtnState(false);
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {
            if (_currentOperation == Operation.None)
                return;

            var firstNumber = double.Parse(_firstValue);
            var secondNumber = double.Parse(_secondValue);
            double result = Calculate(firstNumber, secondNumber);

            tbScreen.Text = result.ToString();
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            _isTheResultOnTheScreen = true;
            SetResultBtnState(true);
            SetBtnCommaState(true);

        }
        private double Calculate(double firstNumber, double secondNumber)
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
                    return firstNumber / secondNumber;
            }
            return 0;
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            tbScreen.Text = string.Empty;
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
        }
        private void SetOperationBtnState(bool value)
        {
            BtnAddition.Enabled = value;
            BtnSubstraction.Enabled = value;
            BtnMultiplication.Enabled = value;
            BtnDivision.Enabled = value;
        }
        private void SetResultBtnState(bool value)
        {
            BtnResult.Enabled = value;
        }
        private void SetBtnCommaState(bool value)
        {
            BtnComma.Enabled = value;
        }
    }
}