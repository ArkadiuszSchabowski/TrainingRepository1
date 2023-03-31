using System;

namespace Lekcja7
{
    class Program
    {
        static void Main(string[] args)
        {
            // TYPY DANYCH [Liczby zmiennoprzecinkowe]

            float varFloat = 123.14f;
            Console.WriteLine(varFloat);

            Console.WriteLine($"Float min: {float.MinValue}, max: {float.MaxValue}");

            double varDouble = 13.2345d;
            Console.WriteLine(varDouble);
            Console.WriteLine($"Double min: {double.MinValue}, max: {double.MaxValue}");

            Console.WriteLine("{0:N20}", 0.1f);

            decimal varDecimal = 5.5m;
            Console.WriteLine(varDecimal);
            Console.WriteLine("{0:N20}", 0.1m);
        }
    }
}
