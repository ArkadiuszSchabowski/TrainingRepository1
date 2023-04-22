using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoloableContactBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateDisplayMember();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Person());

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int savedIndex = listBox1.SelectedIndex;

            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            if (listBox1.SelectedIndex != 0)
            {
                listBox1.SelectedIndex = savedIndex - 1;
            }


        }
        private void UpdateDisplayMember()
        {
            listBox1.DisplayMember = "Name";
        }
    }
}
