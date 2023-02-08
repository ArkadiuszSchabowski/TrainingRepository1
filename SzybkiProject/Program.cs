using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzybkiProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number1, number2, result;

            while (true)
            {

                Console.WriteLine("Podaj pierwszą liczbę");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę");
                number2 = int.Parse(Console.ReadLine());

                CompareValues(number1, number2);

                result = SumValues(number1, number2);

                Console.WriteLine("Twój wynik to" + result);
            }
        }
        private static void CompareValues(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                Console.WriteLine("Pierwsza liczba jest większa od drugiej");
            }
            else if (firstValue == secondValue)
            {
                Console.WriteLine("Liczby są sobie równe");
            }
            else
            {
                Console.WriteLine("Pierwsza liczba jest mniejsza od drugiej");
            }
        }
        private static int SumValues(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
    }
    }
}