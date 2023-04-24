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
            CheckForBirthdays();
            UpdateDisplayMember();
        }
        private void CheckForBirthdays()
        {
            Person person;
            string birthdays ="";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                person = listBox1.Items[i] as Person;

                if (person != null && person.birthday.Day == DateTime.Today.Day && person.birthday.Month == DateTime.Today.Month)
                    birthdays += person.name + " is " + (DateTime.Now.Year - person.birthday.Year).ToString() + " today! \n";
            }
            if (birthdays != "")
            {
                MessageBox.Show(birthdays, "Birthdays");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Person());

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;

            int savedIndex = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            if (savedIndex -1 > 0)
                listBox1.SelectedIndex = savedIndex -1;
            else if(listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
        }
        private void UpdateDisplayMember()
        {
            listBox1.DisplayMember = "";
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }


            Person person = (Person)listBox1.SelectedItem;

            textBoxName.Text = person.name;
            textBoxEmail.Text = person.email;
            textBoxAdress.Text = person.adress;
            dateTimePicker1.Value = person.birthday;
            textBoxNotes.Text = person.notes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }


            Person person = (Person)listBox1.SelectedItem;

            person.name = textBoxName.Text;
            person.email = textBoxEmail.Text;
            person.adress = textBoxAdress.Text;
            person.birthday = dateTimePicker1.Value;
            person.notes = textBoxNotes.Text;

            UpdateDisplayMember();
        }
    }
}
