using System;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak masz na imię?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
