using System;

namespace Lekcja26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst: ");
            string text = Console.ReadLine();

            foreach (char c in text)
            {
                Console.WriteLine(c);
            }
        }
    }
}
