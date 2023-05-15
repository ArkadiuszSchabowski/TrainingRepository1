using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlTraining
{

    public class Orders
    {
        public static List<List<string>> Polska = new List<List<string>>();
        public static List<List<string>> Litwa = new List<List<string>>();
        public static List<List<string>> Wlochy = new List<List<string>>();

        public static string country;
        public static string Country 
        {
            get { return country; } 
        }
        public Orders()
        {
            country = "Nowy Kraj";
        }

    }
}
