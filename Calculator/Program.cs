using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine();
        }

        static void Engine()
        {
            double x1, x2;
            string operation;

            Console.WriteLine("Aplikacja konsolowy kalkulator\n");

            while (true)
            {
                Console.WriteLine("Podaj pierwszą liczbę");
                double.TryParse(Console.ReadLine(), out x1);
                Console.WriteLine("Podaj drugą liczbę");
                double.TryParse(Console.ReadLine(), out x2);
                Console.WriteLine("Podaj operację, którą chcesz wykonać.\nDostępne operacje: dodaj, odejmij, pomnóż, podziel");
                Console.WriteLine("");
                operation = Console.ReadLine();
                Console.WriteLine("");

                switch (operation)
                {
                    case "dodaj":
                        Console.WriteLine($"Twój wynik to: {x1 + x2}\n");
                        break;
                    case "odejmij":
                        Console.WriteLine($"Twój wynik to: {x1 - x2}\n");
                        break;
                    case "pomnóż":
                        Console.WriteLine($"Twój wynik to: {x1 * x2}\n");
                        break;
                    case "podziel":
                        Console.WriteLine($"Twój wynik to: {x1 / x2}\n");
                        break;
                    default:
                        Console.WriteLine("Podałeś złą operację");
                        break;
                }
            }
        }

        static void GetInput()
        {

        }
    }
}

