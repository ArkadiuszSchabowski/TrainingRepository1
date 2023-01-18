using System;

namespace BladZnaleziony
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Podaj pierwszą liczbę");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            number2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Wynik Twojego dodawania to: " + (number1 + number2));
        }
    }
}
