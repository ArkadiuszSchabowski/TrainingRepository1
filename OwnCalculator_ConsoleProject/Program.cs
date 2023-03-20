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
            bool result;
            bool result2;
            bool isTrue = true;
            double number;
            double number2;
            double dodawanie;
            double odejmowanie;
            double mnozenie;
            double dzielenie;

            while (isTrue == true)
            {
                Console.Clear();
                Console.WriteLine("Podaj pierwszą liczbę");
                result = double.TryParse(Console.ReadLine(), out number);
                if (result)
                {

                }
                else
                {
                    Console.WriteLine("Nieprawidłowa liczba");
                    isTrue = false;
                }
                Console.WriteLine("Podaj drugą liczbę");
                result2 = double.TryParse(Console.ReadLine(), out number2);
                if (result2)
                {
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa liczba");
                    isTrue = false;
                }
                Console.WriteLine("Wybierz operację: +,-,*,/");

                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        dodawanie = Dodaj(number, number2);
                        Console.WriteLine(dodawanie);
                        Console.ReadKey();
                        break;

                    case "-":
                        odejmowanie = Odejmij(number, number2);
                        Console.WriteLine(odejmowanie);
                        Console.ReadKey();
                        break;

                    case "*":
                        mnozenie = Razy(number, number2);
                        Console.WriteLine(mnozenie);
                        Console.ReadKey();
                        break;

                    case "/":
                        dzielenie = Podziel(number, number2);
                        Console.WriteLine(dzielenie);
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Program został zamknięty, ponieważ nie podałeś poprawnych liczb");
            Console.ReadKey();
        }

        private static double Dodaj(double a, double b)
        {
            double wynik = a + b;
            return wynik;
        }
        private static double Odejmij(double a, double b)
        {
            double wynik = a-b;
            return wynik;
        }
        private static double Razy(double a, double b)
        {
            double wynik = a*b;
            return wynik;
        }
        private static double Podziel(double a, double b)
        {
            double wynik = a/b;
            return wynik;
        }
    }
}
