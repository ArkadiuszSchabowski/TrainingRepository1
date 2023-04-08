using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wygrana;

            try
            {
                while (true)
                {
                    Console.WriteLine("Witaj w świnskich milionerach");
                    Console.WriteLine("Podaj swoje imię");
                    string name = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Witaj w milionerach {name}.");
                    PytanieZa100.PytaniePierwsze();
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Wystąpił problem, ale już nad tym pracujemy!");
            }
        }
    }
}
