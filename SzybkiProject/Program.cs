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
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            while (i <= 3)
            {
                while (j <= 3)
                {
                    Console.WriteLine("i " + i +"    " + "j " + j);
                    j++;
                }
                j = 0;
                i++;
            }
            Console.ReadKey();
        }
    }
}