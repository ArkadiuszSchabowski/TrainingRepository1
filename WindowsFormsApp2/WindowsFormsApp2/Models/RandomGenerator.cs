using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Models
{
    public class RandomGenerator
    {
        Random rnd = new Random();
        int _barCode;

        public string AddRouteNumberToTheContractor(string country)
        {
            string route = "";
            string number = rnd.Next(1, 500).ToString();
            string selectedCountry = country;

            switch (selectedCountry)
            {
                case "Polska":
                    route = "P" + number;
                    break;
                case "Litwa":
                    route = "L" + number;
                    break;
                case "Wlochy":
                    route = "W" + number;
                    break;
                case "Czechy":
                    route = "C" + number;
                    break;
                case "Niemcy":
                    route = "N" + number;
                    break;
                case "Francja":
                    route = "F" + number;
                    break;
                default:
                    route = "0";
                    break;
            }
            return route;
        }
        private int AddBarCodeToTheContractor()
        {
            _barCode = rnd.Next(100000000, 999999999);
            return _barCode;
        }
    }
}
