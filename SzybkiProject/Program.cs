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
            int ladderHeight;
            Console.WriteLine("Podaj wysokość drabiny");
            ladderHeight = int.Parse(Console.ReadLine());

            for (int i = 0; i < ladderHeight; i++)
            {
                for (int j = 0; j < ladderHeight; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    if (i % 2 == 1)
                    {
                        if (j==0 || j == ladderHeight - 1)
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
