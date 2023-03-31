using System;

namespace Lekcja17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatory logiczne
            // bool = true false
            bool wynik = false || false; // OR
            Console.WriteLine(wynik);

            wynik = false && false; // AND
            Console.WriteLine(wynik);

            // !=
            wynik = !false;
            Console.WriteLine(wynik);

            Console.WriteLine((true || true) && !false);
        }
    }
}
