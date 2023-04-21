using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Category();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                koszyk.Items.Add(lista.SelectedItem);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(koszyk.SelectedIndex  >= 0)
            koszyk.Items.RemoveAt(koszyk.SelectedIndex);
        }
        private void Category()
        {
            lista.Items.Add("Cats");
            lista.Items.Add("Dogs");
            lista.Items.Add("Guinea Piggs");
        }
    }
}
