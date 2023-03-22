namespace SwineczkaProgramujeKalkulator
{
    public enum Operation
    {
        Addition,
        Substraction,
        Multiplication,
        Division,
    }
    public partial class Form1 : Form
    {
        public string _firstValue;
        public string _secondValue;
        public string _currentOperation;
        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {

            var clickedValue = (sender as Button).Text;

            if (tbScreen.Text == "0")
                tbScreen.Clear();

            tbScreen.Text += clickedValue;

        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {

        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {

        }
    }
}