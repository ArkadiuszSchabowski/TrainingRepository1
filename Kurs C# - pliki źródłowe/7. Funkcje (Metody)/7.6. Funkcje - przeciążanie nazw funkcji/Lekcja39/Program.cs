using System;

namespace Lekcja39
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5);
            Add(5, 10);
            Add(5, 10, 100);
        }

        static void Add(int a)
        {
            Console.WriteLine(++a);
        }

        static double Add(double a)
        {
            return (int)++a;
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
}
