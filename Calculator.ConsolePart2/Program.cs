using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsolePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double number2;
            bool result;
            string operation;
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj pierwszą liczbę");
                    result = double.TryParse(Console.ReadLine(), out number);
                    if (!result)
                    {
                        Console.WriteLine("Podana wartość nie jest liczbą");
                        continue;
                    }
                    Console.WriteLine("Wybierz operację +,-,*,/");
                    operation = Console.ReadLine();
                    Console.WriteLine("Podaj drugą liczbę");
                    result = double.TryParse(Console.ReadLine(), out number2);
                    if (!result)
                    {
                        Console.WriteLine("Podana wartość nie jest liczbą");
                        continue;
                    }
                    var result2 = Calculate(number, number2, operation);
                    Console.WriteLine(result2);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static double Calculate(double number, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                        return number + number2;
                case "-":
                        return number - number2;
                case "*":
                        return number * number2;
                case "/":
                        return number / number2;
                default:
                    throw new Exception("Podano niewłaściwą operację");
            }
        }
    }
}

