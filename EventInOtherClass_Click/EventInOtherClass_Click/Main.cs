using System;
using System.Windows.Forms;

namespace EventInOtherClass_Click
{
    public partial class Main : Form
    {
        private Second second;

        public Main()
        {
            InitializeComponent();
            second = new Second(listBox1, textBox1);
            btnAdd.Click += second.BtnAdd_Click;
            btnRemove.Click += second.BtnRemove_Click;
        }
    }
}