using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                if (textBox1.Text.Length != 0)
                {
                    if (listBox1.Items.Contains(textBox1.Text))
                    {
                        DialogResult result = MessageBox.Show("Element jest już na liście. Czy chcesz go dodaj ponownie?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            MessageBox.Show("Produkt nie został dodany ponownie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    listBox1.Items.Add(textBox1.Text);
                    progressBar1.Value += 10;
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Nie można dodać pustego elementu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista jest już pełna", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            if (i != -1)
            {
                listBox1.Items.RemoveAt(i);
                progressBar1.Value -= 10;
            }
            else
            {
                MessageBox.Show("Żaden element nie został zaznaczony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            progressBar1.Value = 0;
        }
    }
}
