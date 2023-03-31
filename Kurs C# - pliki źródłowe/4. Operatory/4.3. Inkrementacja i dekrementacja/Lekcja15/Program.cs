using System;

namespace Lekcja15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inkrementacja i dekrementacja

            int a = 5;
            // a += 1;
            a++; // c++
            Console.WriteLine(a);

            // a -= 1;
            a--;
            Console.WriteLine(a);
            Console.WriteLine(++a);

            Console.WriteLine(--a);
            int b = a--;
            Console.WriteLine(b);

        }
    }
}
