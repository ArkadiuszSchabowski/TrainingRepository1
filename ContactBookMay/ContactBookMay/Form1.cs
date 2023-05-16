using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBookMay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckforBirthdays();
            UpdateDisplayMember();
        }

        private void CheckforBirthdays()
        {
            Person person;
            string birthdays = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                person = listBox1.Items[i] as Person;

                if (person != null && person.birthday.Day == DateTime.Today.Day && person.birthday.Month == DateTime.Today.Month)
                {
                    birthdays = (person.name + " is " + (DateTime.Today.Year - person.birthday.Year).ToString() + " today! \n");

                    if (birthdays != null)
                    {
                        MessageBox.Show(birthdays, "Birthdays!");
                    }
                }
            }
        }

        private void UpdateDisplayMember()
        {
            listBox1.DisplayMember = "";
            listBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Person());

            CheckforBirthdays();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            Person person = (Person)listBox1.SelectedItem;

            textName.Text = person.name;
            textEmail.Text = person.email;
            textAdress.Text = person.adress;
            dateBirthday.Value = person.birthday;
            textNotes.Text = person.notes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            Person person = listBox1.SelectedItem as Person;

            person.name = textName.Text;
            person.email = textEmail.Text;
            person.adress = textAdress.Text;
            person.birthday = dateBirthday.Value;
            person.notes = textNotes.Text;

            UpdateDisplayMember();
        }
    }
}
