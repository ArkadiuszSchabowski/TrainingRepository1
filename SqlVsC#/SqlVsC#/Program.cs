using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlVsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = new int[] { 1, 2, 3 };

            Dictionary <int, string> listaProduktow = new Dictionary<int, string>();
            listaProduktow.Add(1, "Lodowka = 2500zl");
            listaProduktow.Add(2, "Kuchenka = 1500zl");
            listaProduktow.Add(3, "Telewizor = 3500zl");

            foreach (var item in listaProduktow)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nWybierz produkt:\n1.Lodowka\n2.Kuchenka\n3.Telewizor");
            ConsoleKey wybor = Console.ReadKey().Key;

            switch (wybor)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Twoj produkt ma srednia cene!");
                    break;
                case ConsoleKey.D2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Twoj produkt kosztuje malo!");
                    break;
                case ConsoleKey.D3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Twoj produkt kosztuje duzo!");
                    break;
                default:
                    Console.WriteLine("Niewlasciwy wybor");
                    break;

            }
            Console.ReadKey();
        }
    }
}
