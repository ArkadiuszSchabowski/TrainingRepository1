using System;

namespace Lekcja21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());

            // if { } else { }
            string wynik = a % 2 == 0 ? "Parzysta" : "Nieparzysta";

            Console.WriteLine(wynik);
        }
    }
}
