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
            Add(2, 4);
            //Addition(2, 4);
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Addition(int a, int b)
        {
            int wynik = a + b;
            Console.WriteLine($"Your result is: {wynik}");


        }
    }
}
