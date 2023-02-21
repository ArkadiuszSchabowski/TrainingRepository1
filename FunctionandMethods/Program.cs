using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionandMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Substraction(19, 3);
            //Multiplication(10,3);
            //    Addition();
            Console.ReadKey();
        }
        static int Substraction(int a, int b)
        {
            int wynik = a - b;
            Console.WriteLine(wynik);
            if (wynik > 10)
            {
                Console.WriteLine("Twój wynik jest większy od 10");
            }
            else if (wynik == 10)
            {
                Console.WriteLine("Twój wynik jest równy 10");
            }
            else
            {
                Console.WriteLine("Twój wynik jest mniejszy od 10");
            }
            return wynik;
        }
        static void Multiplication(int a, int b)
        {
            int wynik = a * b;
            Console.WriteLine(wynik);
        }

        static void Addition()
        {
            int a = 5;
            int b = 7;
            int wynik = a + b;
            Console.WriteLine($"Twój wynik to: {wynik}");
        }
    }
}
