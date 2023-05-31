using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEnglishFlashCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CountWords();
        }
        private void CountWords()
        {
            firstLabel.Text = "Your dictionary contains " + listBox1.Items.Count + " words!";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("You can't add word empty!");
            }

            if (textBox1.Text != string.Empty)
            {
                if (!listBox1.Items.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    CountWords();
                }
                else
                {
                    MessageBox.Show("List contains your word!");
                }
            }
        }
    }
}
