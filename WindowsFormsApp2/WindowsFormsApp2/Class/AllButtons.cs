using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Class
{
    public static class AllButtons
    {
        public static void btnAdd_Click(object sender, EventArgs e)
        {
            SomeMethods.AddRecord();

            LabelCountContractors.CountContractors();

            SerializeAndDeserialize.SaveData();

            SomeMethods.ClearFields();
        }
        public static void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                SomeMethods.RemoveRecord();

                SerializeAndDeserialize.SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void btnReset_Click(object sender, EventArgs e)
        {
             SomeMethods.ClearFields();
        }
        public static void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit = MessageBox.Show("Czy na pewno chcesz wyjsc z aplikacji?", "Moto-Profil app", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
                if (iExit == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
