using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Styczeń
{
    internal class Program
    {
        static void NumbersInCSharp()
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("Wprowadź pierwszą liczbę ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Twoja liczba to: {a}!");

            Console.WriteLine("Wprowadź drugą liczbę ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Twoja liczba to: {b}!");

            Console.WriteLine($"Wynik mnożenia dwóch podanych przez Ciebie liczb to: {a * b}");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            NumbersInCSharp();
        }
    }
}
