using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvNewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateMember();
        }

        private void UpdateMember()
        {
            listBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Kontrahent());
        }
    }
}
