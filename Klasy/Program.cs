using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, result, result1;

            Calculator calculator = new Calculator();
            Console.WriteLine("Podaj pierwszą cyfrę");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj pierwszą cyfrę");
            number2 = Convert.ToDouble(Console.ReadLine());
            result = calculator.Sum(number1, number2);
            Console.WriteLine("wynik dodawania: " + result);
            result1 = calculator.Difference(number1, number2);
            Console.WriteLine("wynik odejmowania: " + result1);
            Console.ReadKey();
        }
    }
}
class Calculator
{
    public double Sum(double a, double b)
    {
        return a + b;
    }
    public double Difference(double a, double b)
    { 
        return a - b; 
    }
}

