using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expedition8k
{
    internal class Program
    {
        static void WorkWithIntegers()
        {

            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"Twój wynik to {c}");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            double a, b, c;
            a = 10;
            b = 3;
            c = a / b;

            Console.WriteLine(Math.Round(c, 2));
            Console.ReadKey();
        }
    }
}
