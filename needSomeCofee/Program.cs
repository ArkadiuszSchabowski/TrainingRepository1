using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace needSomeCofee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            bool zmienna1, zmienna2;

            Console.WriteLine("Podaj pierwszą cyfrę");
            zmienna1 = double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Podaj drugą cyfrę");
            zmienna2 = double.TryParse(Console.ReadLine(), out number2);
            if (zmienna1 == false && zmienna2 == false)
            {
                Console.WriteLine("Obie liczby są nieprawidłowe");
            }
            else if(zmienna1 == false || zmienna2 == false)
            {
                Console.WriteLine("Jedna z liczb jest nieprawidłowa");
            }
            else
            {
                Console.WriteLine($"Your result is: {number1 + number2}.");
            }
            Console.ReadKey();
        }
    }
}
