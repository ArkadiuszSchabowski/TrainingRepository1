using System.Linq;

namespace WindowsFormsApp2.Models
{
    public class ValidationHelper
    {
        public static bool IsValidCountry(string country)
        {
            string[] allowedCountries = { "Polska", "Czechy", "Francja", "Litwa", "Niemcy", "Włochy" };
            return allowedCountries.Contains(country);
        }
    }
}