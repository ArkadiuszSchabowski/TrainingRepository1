using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzybkiProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a = 1;
            double b = 3;
            a %= b;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
