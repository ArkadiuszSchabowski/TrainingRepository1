using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilionersOnWindowsForm_TestOwnSkills
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        public void Start()
        {
            int accountBalance = 0;
            label1.Text = $"Your account balance is: {accountBalance}";
            lblQuestion.Text = Questions.FirstQuestion();
        }
    }
}
