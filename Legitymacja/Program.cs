using Legitymacja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legitymacja
{
    class Karta
    {
       public string Name { get; set; }

        public int Number { get; set; }

        public decimal Kilometers { get; }
        public DateTime Date { get; }
        public string Notes { get; }
    }

    class Tekstowa
    {
        static void Main(string[] args)
        {
            Karta Dane = new Karta();

            Dane.Name = "Arkadiusz";
            System.Console.WriteLine(Dane.Name);

            Dane.Number = 46190291;
            System.Console.WriteLine(Dane.Number);

            System.Console.WriteLine(Dane.Kilometers);

            System.Console.WriteLine(Dane.Date);

            System.Console.WriteLine(Dane.Notes);

            System.Console.ReadKey();
        }
    }
}
