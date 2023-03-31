using System;

namespace Lekcja28
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
        hello:
            Console.WriteLine("Hello World!");
            i++;

            if (i < 10)
                goto hello;
        }
    }
}
