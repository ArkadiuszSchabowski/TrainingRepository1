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
        private bool _isTheResultOnTheScreen;
        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;
                tbScreen.Text = string.Empty;
            }

            var clickedValue = (sender as Button).Text;

            if (tbScreen.Text == "0")
                tbScreen.Text = string.Empty;

            tbScreen.Text += clickedValue;

            if (_currentOperation != Operation.None)
            {
                _secondValue += clickedValue;
            }
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

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;
            var operation = (sender as Button).Text;

            _currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Substraction,
                "*" => Operation.Multiplication,
                "/" => Operation.Substraction,
                _ => Operation.None,

            };

            tbScreen.Text += $" {operation} ";
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            tbScreen.Text = string.Empty;
            _currentOperation = Operation.None;
            _firstValue = string.Empty;
            _secondValue = string.Empty;
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(_firstValue);
            double secondNumber = double.Parse(_secondValue);

            double result = Calculate(firstNumber, secondNumber);

            tbScreen.Text = result.ToString();
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            _isTheResultOnTheScreen = true;


        }

    }
}