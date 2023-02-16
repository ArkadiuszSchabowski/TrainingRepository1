using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SzybkiProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 5;
            string nazwa = "10";
            string b;

            b = i.ToString() + 10;

            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
