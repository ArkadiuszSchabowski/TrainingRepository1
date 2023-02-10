using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SherpaLoop_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;

            while (i <= 30)
            {
                if(i % 7 == 0)
                {
                    sum = sum + i;
                }
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

