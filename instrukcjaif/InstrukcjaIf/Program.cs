using System;

namespace BladZnaleziony
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;

            Console.WriteLine("Podaj pierwszą liczbę");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Podaj drugą liczbę");
            double.TryParse(Console.ReadLine(), out number2);


            Console.WriteLine("Wynik Twojego dodawania to: " + (number1 + number2));
        }
    }
}