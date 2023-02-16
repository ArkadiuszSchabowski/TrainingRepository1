using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Wyswietl prostokat o wymiarach x i y. Wymiary podaje uzytkownik. Prostokat ma byc zbudowany z gwiazdek (8).

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            s1 = "witaj";
            s2 = " świecie";
            s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}

//            string szerokosc, wysokosc;
//            int x, y;
//            Console.WriteLine("Wprowadz wysokosc prostokata");
//            wysokosc = Console.ReadLine();
//            Console.WriteLine("Wprowadz szerokosc prostokata");
//            szerokosc = Console.ReadLine();

//            x = Convert.ToInt32(szerokosc);
//            y = Convert.ToInt32(wysokosc);

//            for (int i = 0; i < x; i++)
//            {
//                for (int j = 0; j < y; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine("");
//            }
//            Console.ReadKey();
//        }
//    }
//}