using System;

namespace Lekcja66
{
    class Program
    {
        public delegate int CalcDelegate(int a, int b);

        static void Main(string[] args)
        {
            // CalcWithText(CalcDelegate(2, 5), 2, 5);
            CalcDelegate calcDelegate = Add;
            CalcWithText(calcDelegate.Invoke, 2, 5);

            CalcDelegate calcDelegate2 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(calcDelegate2.Invoke(2, 5));
            CalcWithText(calcDelegate2.Invoke, 2, 5);

            Func<int, int, int> funcDelegate = Add;
            CalcWithText(funcDelegate.Invoke, 2, 5);

            Action<int, int> action = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            action.Invoke(2, 5);

            Predicate<int> predicate = delegate (int a)
            {
                return a == 0;
            };
            Console.WriteLine(predicate.Invoke(5));
            Console.WriteLine(predicate.Invoke(0));
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
