using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForBirthays();
            UpdateDisplayMember();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Person());

            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            CheckForBirthays();
        }
        private void UpdateDisplayMember()
        {
            listBox1.DisplayMember = "";
            listBox1.DisplayMember = "Name";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;

            int savedIndex = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            if (listBox1.SelectedIndex == 0)
                return;

            listBox1.SelectedIndex = savedIndex - 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            Person person = listBox1.SelectedItem as Person;

            textName.Text = person.name;
            textEmail.Text = person.email;
            textAdress.Text = person.adress;
            textNotes.Text = person.notes;
            birthayPicker.Value = person.birthay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            Person person = listBox1.SelectedItem as Person;

            person.name = textName.Text;
            person.email = textEmail.Text;
            person.adress = textAdress.Text;
            person.birthay = birthayPicker.Value;
            person.notes = textNotes.Text;

            UpdateDisplayMember();
        }
        private void CheckForBirthays()
        {
            Person person;
            string birthdays = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                person = listBox1.Items[i] as Person;


                if (person != null && person.birthay.Day == DateTime.Today.Day && person.birthay.Month == DateTime.Today.Month)
                {
                    birthdays += person.name + " is " + (DateTime.Today.Month - person.birthay.Month).ToString() + " today";
                }
                if (birthdays != "")
                {
                    MessageBox.Show(birthdays, "Birthdays");
                }
            }
        }
    }
}
