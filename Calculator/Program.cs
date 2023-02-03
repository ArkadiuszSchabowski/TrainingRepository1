using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj w aplikacji kalkulator\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj proszę 1 liczbę");
                    var number1 = GetInput();

                    Console.WriteLine($"Podaj operację, którą chcesz wykonać. Dostępne opcje: +, -, *, /.");
                    var operation = Console.ReadLine();

                    Console.WriteLine("Podaj proszę 2 liczbę");
                    var number2 = GetInput();
                    var result = Calculate(number1, number2, operation);

                    Console.WriteLine($"Twój wynik to: {Math.Round(result, 2)}.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static double GetInput()
        {
            if (!double.TryParse(Console.ReadLine(), out double input))
                throw new Exception("Podana wartość nie jest liczbą\n");

            return input;
        }
        private static double Calculate(double x1, double x2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return x1 + x2;
                case "-":
                    return x1 - x2;
                case "*":
                    return x1 * x2;
                case "/":
                    return x1 / x2;
                default:
                    throw new Exception("Podałeś złą operację\n");
            }
        }
    }
}
