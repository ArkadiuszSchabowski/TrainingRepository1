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

        }
    }
}








/* Program numer 2

            bool y1, y2;
            double x1, x2;

            Console.WriteLine("Podaj pierwszą cyfrę");
            y1 = double.TryParse(Console.ReadLine(), out x1);
            Console.WriteLine("Podaj drugą cyfrę");
            y2 = double.TryParse(Console.ReadLine(), out x2);

            if(y1 && y2)
            {
                Console.WriteLine("Obie cyfry są prawidłowe");
            }
            else
            {
                Console.WriteLine("Przynajmniej jedna cyfra jest nieprawidłowa");
            }
        }
    }
}

Program Numer 1
        
        {
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
}*/