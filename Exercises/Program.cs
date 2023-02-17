using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int labbelHeight;

            Console.WriteLine("Podaj wysokość drabiny");
            labbelHeight = int.Parse(Console.ReadLine());

            for (int i = 0; i < labbelHeight; i++)
            {
                for (int j = 0; j < labbelHeight; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 0 || j == labbelHeight-1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

