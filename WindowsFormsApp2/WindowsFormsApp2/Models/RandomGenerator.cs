using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Models
{
    public class RandomGenerator
    {
        Random rnd = new Random();
        int _barCode;
        private List<string> generatedRoutes = new List<string>();

        private string GenerateRoute(string country, string number)
        {
            string route = "";

            switch (country)
            {
                case "Polska":
                    route = "P" + number;
                    break;
                case "Czechy":
                    route = "C" + number;
                    break;
                case "Francja":
                    route = "F" + number;
                    break;
                case "Litwa":
                    route = "L" + number;
                    break;
                case "Niemcy":
                    route = "N" + number;
                    break;
                case "Włochy":
                    route = "W" + number;
                    break;
                default:
                    route = "0";
                    break;
            }
            return route;
        }

        public string AddRouteNumberToTheContractor(string country)
        {
            string route = "";
            string number = rnd.Next(1, 500).ToString();
            string selectedCountry = country;

            route = GenerateRoute(selectedCountry, number);

            if (generatedRoutes.Contains(route))
            {
                while (generatedRoutes.Contains(route))
                {
                    number = rnd.Next(1, 500).ToString();
                    route = GenerateRoute(selectedCountry, number);
                }
            }
            generatedRoutes.Add(route);

            return route;
        }

        public int AddBarCodeToTheContractor()
        {
            _barCode = rnd.Next(100000000, 999999999);
            return _barCode;
        }
    }
}