using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Models
{
    public static class SetWindowsProperty
    {
        public static void StrechTheWindowsToFullScreen()
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
