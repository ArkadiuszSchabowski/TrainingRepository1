using System;

namespace BladZnaleziony
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            double number2;
            Console.WriteLine("Podaj wynik dzielenia");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twój wynik to " + (number1 / number2));
        }
    }
}
