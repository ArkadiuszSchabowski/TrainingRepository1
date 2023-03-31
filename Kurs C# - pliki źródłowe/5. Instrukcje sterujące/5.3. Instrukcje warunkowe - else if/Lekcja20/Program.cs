using System;

namespace Lekcja20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instrukcje warunkowe - ELSE IF

            Console.WriteLine("Podaj liczbę:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Liczba jest większa od 0");
            }
            else if (num < 0)
            {
                Console.WriteLine("Liczba jest mniejsza od 0");
            }
            else if (num == 0)
            {
                Console.WriteLine("Liczba jest równa 0");
            }
        }
    }
}
