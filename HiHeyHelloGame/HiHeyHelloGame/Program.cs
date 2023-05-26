using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiHeyHelloGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Komputer wypisze Hi jesli liczba jest podzielna przez 3, Hello jesli przez 5, a Hello Piggy jesli przez 15");

            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i + " HElLO PIGGY");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " HELLO");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " HI");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
