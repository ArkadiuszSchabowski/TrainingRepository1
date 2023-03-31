using System;

namespace Lekcja38
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello("Hello World", 3);
            Hello("Hi");
            Hello();
        }

        static void Hello(string text = "Hello", int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
