using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyPodzielne
{
    //Zrealizujemy sobie teraz zadanie w C#, które często pojawia się na rozmowach kwalifikacyjnych. Zadanie brzmi: Napisz program, który wyświetla liczby od 1 do 100. Dla liczb podzielnych przez 3 niech program wyświetli „Fizz”, dla liczb podzielnych przez 5 niech wyświetli ‚Buzz’, a dla liczb podzielnych przez 15 niech wyświetli ‚FizzBuzz’.
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstSolution();
        }

        public static void FirstSolution()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}