using System;

namespace Lekcja19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instrukcje warunkowe - ELSE

            Console.WriteLine("Ile masz lat?");
            int wiek = int.Parse(Console.ReadLine());

            if (wiek >= 18)
            {
                Console.WriteLine("Zapraszamy!");
                Console.WriteLine("Zapraszamy!");
            }
            else
            {
                Console.WriteLine("Nie masz 18 lat!");
                Console.WriteLine("Przykro nam.");
            }
        }
    }
}
