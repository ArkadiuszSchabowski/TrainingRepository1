using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVSReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 7;
            int result = Addition(5, 10);
            Console.WriteLine(result);
            Substraction(a, b);
            Console.WriteLine();
            Console.WriteLine($"a: {a} + b: {b}");
            Console.ReadKey();
        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Substraction(int a, int b)
        {

        }
    }
}
