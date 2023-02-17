using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearrnEtc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wysokoscDrabiny;
            Console.WriteLine("Podaj szerokość drabiny");
            wysokoscDrabiny = int.Parse(Console.ReadLine());

            for (int i = 0; i < wysokoscDrabiny; i++)
            {
                for (int j = 0; j < wysokoscDrabiny; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
