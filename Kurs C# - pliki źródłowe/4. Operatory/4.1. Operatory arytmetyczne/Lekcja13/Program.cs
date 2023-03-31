using System;

namespace Lekcja13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operatory arytmetyczne

            Console.WriteLine("Podaj A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj B:");
            int b = int.Parse(Console.ReadLine());

            // int wynik = a + b;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {(float)a / (float)b}");
            Console.WriteLine($"{a} % {b} = {a % b}");

            Console.WriteLine("-----------");
            Console.WriteLine(((a + a) * a));

            Console.WriteLine("-----------");
            Console.WriteLine(Math.Pow(a, b));
            Console.WriteLine(Math.Sqrt(a));
        }
    }
}
