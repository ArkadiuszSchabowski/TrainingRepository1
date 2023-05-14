using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateDisplayMember();
        }

        private void BtnAddContractor_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Contractors());
        }

        private void UpdateDisplayMember()
        {
            listBox1.DisplayMember = "CompanyName";
        }

        private void BtnRemoveContractor_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
