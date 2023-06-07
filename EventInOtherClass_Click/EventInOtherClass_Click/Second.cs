using System;
using System.Windows.Forms;

namespace EventInOtherClass_Click
{
    public class Second
    {
        private ListBox listBox;
        private TextBox textBox;

        public Second(ListBox listBox, TextBox textBox)
        {
            this.listBox = listBox;
            this.textBox = textBox;
        }

        public void BtnAdd_Click(object sender, EventArgs e)
        {
            if (textBox.Text != string.Empty)
            {
                listBox.Items.Add(textBox.Text);
            }
        }

        public void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }
    }
}

