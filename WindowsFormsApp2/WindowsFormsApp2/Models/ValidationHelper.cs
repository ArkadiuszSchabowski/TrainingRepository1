using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    public class ValidationHelper
    {
        public static bool IsValidCountry(string country)
        {
            string[] allowedCountries = { "Polska", "Litwa", "Wlochy", "Czechy", "Niemcy", "Francja" };
            return allowedCountries.Contains(country);
        }
    }
}
