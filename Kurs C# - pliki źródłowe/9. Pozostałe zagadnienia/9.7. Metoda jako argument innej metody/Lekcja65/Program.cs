using System;

namespace Lekcja65
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcWithText(Add, 2, 5);
        }

        static void CalcWithText(Func<int, int, int> func, int a, int b)
        {
            int res = func.Invoke(2, 5);
            Console.WriteLine($"Wynik = {res}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
