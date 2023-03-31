using System;

namespace Lekcja14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skrócone operatory arytmetyczne

            int a = 5;
            // a = a + 10; - DRY
            a += 10; // 15
            a -= 3; // 12
            a *= 2; // 24
            a /= 6; // 4
            a %= 3; // 1
            Console.WriteLine(a);
        }
    }
}
