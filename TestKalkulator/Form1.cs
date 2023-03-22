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
        private Operation _currentOperation = Operation.None;
        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {

            var clickedValue = (sender as Button).Text;

            if (tbScreen.Text == "0")
                tbScreen.Text = string.Empty;

            tbScreen.Text += clickedValue;
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

        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }
    }
}