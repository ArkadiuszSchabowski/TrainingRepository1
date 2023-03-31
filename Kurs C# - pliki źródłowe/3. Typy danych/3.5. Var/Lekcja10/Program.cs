using System;

namespace Lekcja10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Var

            var a = 2;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            var tekst = "Hello";
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.GetType());

            // tekst = 123; - Błąd
            // var c; - Błąd
        }
    }
}
