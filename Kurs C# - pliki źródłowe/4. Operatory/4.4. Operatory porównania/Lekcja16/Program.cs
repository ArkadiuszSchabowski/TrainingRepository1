using System;

namespace Lekcja16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatory porównania

            Console.WriteLine("Podaj A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj B:");
            int b = int.Parse(Console.ReadLine());

            bool wynik = a == b;
            Console.WriteLine($"{a} == {b} = {a == b}");
            Console.WriteLine($"{a} != {b} = {a != b}");
            Console.WriteLine($"{a} > {b} = {a > b}");
            Console.WriteLine($"{a} < {b} = {a < b}");
            Console.WriteLine($"{a} >= {b} = {a >= b}");
            Console.WriteLine($"{a} <= {b} = {a <= b}");
        }
    }
}
