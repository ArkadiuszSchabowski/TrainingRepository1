using System;

namespace Lekcja18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instrukcje warunkowe
            Console.WriteLine("Ile masz lat?");
            int wiek = int.Parse(Console.ReadLine());
            
            if (wiek >= 18)
            {
                Console.WriteLine("Zapraszamy!");
                if (wiek > 50)
                {
                    Console.WriteLine("Masz więcej niż 50 lat!");
                }    
            }

            if (wiek < 18)
            {
                Console.WriteLine("Nie masz 18 lat!");
            }
        }
    }
}
