using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    internal class ValidationHelper
    {
        private bool IsValidCountry(string country)
        {
            string[] allowedCountries = { "Polska", "Litwa", "Wlochy", "Czechy", "Niemcy", "Francja" };
            return allowedCountries.Contains(country);
        }
    }
}
