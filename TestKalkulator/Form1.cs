namespace TestKalkulator
{
    public enum Operation
    {
        None,
        Addition,
        Substraction,
        Multiplication,
        Division
    }
    public partial class Form1 : Form
    {
        private string _firstValue = "0";
        private string _secondValue = "0";
        private Operation _operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {

            var clickedValue = (sender as Button).Text;
            tbScreen.Text += clickedValue;
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            tbScreen.Text = _firstValue;
            tbScreen.Text = string.Empty;

            var operation = (sender as Button).Text;

            tbScreen.Text += operation;

            tbScreen.Text = _secondValue;

            double firstNumber = double.Parse(_firstValue);
            double secondNumber = double.Parse(_firstValue);

            double result = Calculate(firstNumber, secondNumber);

            BtnAddition.Enabled = false;
            BtnSubstraction.Enabled = false;
            BtnMultiplication.Enabled = false;
            BtnDivision.Enabled = false;
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            tbScreen.Text = string.Empty;

            BtnAddition.Enabled = true;
            BtnSubstraction.Enabled = true;
            BtnMultiplication.Enabled = true;
            BtnDivision.Enabled = true;
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }
        private double Calculate(double firstNumber, double secondNumber)
        {

            switch (_operation)
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

        private void SetBtnResultState()
        {
        }
        private void SetBtnOperationState()
        {
        }
    }

}