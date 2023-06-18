using RoadToCvProject.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToCvProject
{
    public partial class Form1 : Form
    {
        public static int _countFruit = 0;
        public static Label FruitLabel { get { return lblFruit; } }

        public Form1()
        {
            InitializeComponent();
            OwnLabel.CountFruit();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                listBox1.Items.Add(textBox1.Text);
                _countFruit++;
                OwnLabel.CountFruit();
                ClearFields();
            }
        }

        private void ClearFields()
        {
            textBox1.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                _countFruit--;
                OwnLabel.CountFruit();
                ClearFields();
            }
        }
    }
}
