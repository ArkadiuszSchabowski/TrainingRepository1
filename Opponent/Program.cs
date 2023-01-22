using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opponent
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string y1;
            int x1, x2;

            Console.WriteLine("Ile zarabiasz rocznie (liczba)?");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ile potrzebujesz zarabiać (liczba)?");
            x2 = Convert.ToInt32(Console.ReadLine());

            if (x1 < x2)
            {
                Console.WriteLine("Weź się za siebie");
                Console.ReadLine();
            }
            if (x1 == x2)
            {
                Console.WriteLine("Zarabiasz dokładnie tyle ile potrzebujesz. Nie stać Cię na więcej?");
                Console.ReadLine();
            }
            if (x1 > x2)
            {
                Console.WriteLine("Zarabiasz więcej niż potrzebujesz. Gratulacje");
                Console.ReadLine();
            }
            else
            {
            }
        }
    }
}
