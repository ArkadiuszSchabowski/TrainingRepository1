using System;

namespace Lekcja67
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcWithText(delegate (int a, int b)
            {
                return a + b;
            }, 2, 5);

            CalcWithText((x, y) => x + y, 2, 5);
        }

        static void CalcWithText(Func<int, int, int> func, int a, int b)
        {
            int res = func.Invoke(2, 5);
            Console.WriteLine($"Wynik = {res}");
        }
    }
}
