using System;

namespace Lekcja35
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello("Hello User", 5);
        }

        static void Hello(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
