using System;

namespace Lekcja41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = 0: " + Silnia(0));
            Console.WriteLine("n = 1: " + Silnia(1));
            Console.WriteLine("n = 2: " + Silnia(2));
            Console.WriteLine("n = 3: " + Silnia(3));
            Console.WriteLine("n = 4: " + Silnia(4));
            Console.WriteLine("n = 5: " + Silnia(5));
            Console.WriteLine("n = -5: " + Silnia(-5));
        }

        static int Silnia(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                return n * Silnia(n - 1);
            }
        }
    }
}
