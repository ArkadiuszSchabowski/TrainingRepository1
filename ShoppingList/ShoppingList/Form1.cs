using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateProgressBar()
        {
            int i = listBox1.Items.Count * 10;
            progressBar1.Value = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Your input value is empty!");
            }

            if (progressBar1.Value == 100)
            {
                MessageBox.Show("The list is full!");
                return;
            }

            if (textBox1.Text != string.Empty)
            {
                if (listBox1.Items.Contains(textBox1.Text))
                {
                    DialogResult result = MessageBox.Show("Do You want add the same product to the list?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        textBox1.Clear();
                        return;
                    }
                }
                listBox1.Items.Add(textBox1.Text);
                UpdateProgressBar();
                textBox1.Clear();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                UpdateProgressBar();
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Value = 0;
        }
    }
}
