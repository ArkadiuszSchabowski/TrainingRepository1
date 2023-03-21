using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnCalculator_ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool result;
                bool result2;
                double number;
                double number2;
                double dodawanie;
                double odejmowanie;
                double mnozenie;
                double dzielenie;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Podaj pierwszą liczbę");
                    result = double.TryParse(Console.ReadLine(), out number);
                    if (result)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Podałeś nieprawidłową liczbę!");
                        Console.ReadKey();
                        break;
                    }

                    Console.WriteLine("Wybierz operację: +,-,*,/");
                    string operation = Console.ReadLine();


                    Console.WriteLine("Podaj drugą liczbę");
                    result2 = double.TryParse(Console.ReadLine(), out number2);
                    Console.WriteLine();
                    if (result2)
                    {
                    }
                    else
                    {
                        Console.WriteLine("Podałeś nieprawidłowa liczbę!");
                        Console.ReadKey();
                        break;
                    }

                    switch (operation)
                    {
                        case "+":
                            dodawanie = Dodaj(number, number2);
                            if (result && result2)
                            {
                                Console.WriteLine(dodawanie);
                            }
                            Console.ReadKey();
                            break;

                        case "-":
                            odejmowanie = Odejmij(number, number2);
                            if (result && result2)
                            {
                                Console.WriteLine(odejmowanie);
                            }
                            Console.ReadKey();
                            break;

                        case "*":
                            mnozenie = Razy(number, number2);
                            if (result && result2)
                            {
                                Console.WriteLine(mnozenie);
                            }
                            Console.ReadKey();
                            break;

                        case "/":
                            dzielenie = Podziel(number, number2);
                            if (result && result2)
                            {
                                Console.WriteLine(dzielenie);
                            }
                            Console.ReadKey();
                            break;
                        default:
                            {
                                throw new Exception("Podałeś złą operację");
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private static double Dodaj(double a, double b)
        {
            double wynik = a + b;
            return wynik;
        }
        private static double Odejmij(double a, double b)
        {
            double wynik = a - b;
            return wynik;
        }
        private static double Razy(double a, double b)
        {
            double wynik = a * b;
            return wynik;
        }
        private static double Podziel(double a, double b)
        {
            double wynik = a / b;
            return wynik;
        }
    }
}
