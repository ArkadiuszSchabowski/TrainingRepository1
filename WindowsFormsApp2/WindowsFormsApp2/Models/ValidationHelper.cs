using System.Linq;

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
