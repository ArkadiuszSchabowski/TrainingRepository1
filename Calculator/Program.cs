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
            Engine();
        }

        static void Engine()
        {

            Console.WriteLine("Aplikacja konsolowy kalkulator\n");

            while (true)
            {
                {
                    try
                    {
                        Console.WriteLine("Podaj pierwszą liczbę");
                        var x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj operację, którą chcesz wykonać.\nDostępne operacje: + , -  , * , / .");
                        var operation = Console.ReadLine();
                        Console.WriteLine("Podaj drugą liczbę");
                        var x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        var result = 0;

                        switch (operation)
                        {
                            case "+":
                                result = x1 + x2;
                                break;
                            case "-":
                                result = x1 - x2;
                                break;
                            case "*":
                                result = x1 * x2;
                                break;
                            case "/":
                                result = x1 / x2;
                                break;
                            default:
                                throw new Exception("Wybrałeś złą operację");
                        }
                        Console.WriteLine($"Wynik Twojego działania to {result}");
                        Console.WriteLine("");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}