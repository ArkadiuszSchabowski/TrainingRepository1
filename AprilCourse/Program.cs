using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AprilCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //DateTime data = DateTime.Now;
            //Console.WriteLine("Podaj datę urodzenia");
            //string dateOfBirth = Console.ReadLine();

            //TimeSpan uplynelo = data - DateTime.Parse(dateOfBirth);

            //Console.WriteLine(uplynelo);
            //Console.ReadLine();

            //const string ZWIERZE = "Świnka";
            //Console.WriteLine(ZWIERZE);
            //Console.ReadKey();

            Console.WriteLine("Podaj liczbę");
            int x = int.Parse(Console.ReadLine());
            string wynik;

            wynik = x % 2 == 0 ? "Parzysta" : "Nieparzysta";
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}