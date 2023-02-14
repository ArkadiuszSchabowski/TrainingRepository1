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
            //Rzutowanie zmiennych

            int i = int.MaxValue;
            double d = 5.9;

            i = (int)d;

            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
