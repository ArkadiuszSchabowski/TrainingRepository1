using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzachownicaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dlugosc");
            int dlugosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Szerokosc");
            int szerokosc = int.Parse(Console.ReadLine());

            for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
