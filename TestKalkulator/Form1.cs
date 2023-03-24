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
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }
    }

}