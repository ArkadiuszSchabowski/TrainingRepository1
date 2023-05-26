using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBookSolo16may
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayMember();
        }

        private void DisplayMember()
        {
            listBox1.DisplayMember = "";
            listBox1.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Person());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person;

            if (listBox1.SelectedItem != null)
            {
                person = listBox1.SelectedItem as Person;

                person.name = textName.Text;
                person.eMail = textEmail.Text;
                person.adress = textAdress.Text;
                person.birthday = dateBirthday.Value;
                person.notes = textNotes.Text;

                DisplayMember();
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            int savedIndex = listBox1.SelectedIndex;

            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            //Sprawdzic to
            if (savedIndex == 0 && listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = savedIndex++;
            }

            //Powiedzmy
            if (savedIndex != 0)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person person;

            person = listBox1.SelectedItem as Person;

            //Sprawdzic czemu nie aktualizuje sie pole textName na "New Person"
            textName.Text = person.name;
            textEmail.Text = person.eMail;
            textAdress.Text = person.adress;
            dateBirthday.Value = person.birthday;
            textNotes.Text = person.notes;
        }
    }
}
