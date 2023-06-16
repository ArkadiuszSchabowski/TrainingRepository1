using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public static class LabelCountContractors
    {
        public static void CountContractors()
        {
            try
            {
                lblCount.Text = $"Ilosc aktualnych kontrahentow: {countContractors}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
