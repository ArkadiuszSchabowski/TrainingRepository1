using System;

namespace Lekcja37
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello("Hello World!", 3);
            // Hello(3, "Hi"); - błąd
            Hello(times: 3, text: "Hi");
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
