using System;

namespace Lekcja24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            int i = 1;

            Console.WriteLine("While:");

            while (i <= a)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Do While:");
            i = 1;

            do
            {
                Console.WriteLine(i);
                i++; // 2
            } while (i <= a);
        }
    }
}
