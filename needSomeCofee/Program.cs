using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace needSomeCofee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
