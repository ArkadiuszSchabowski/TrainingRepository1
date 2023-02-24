using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu
{
    public static class MenuProste
    {
        public static void Menu()
        {
            Console.Title = "Menu Proste";

            while (true)
            {

                Console.Clear();
                Console.WriteLine("Wybierz interesujący Cie dział:");
                Console.WriteLine("1.Dział pierwszy - świnki");
                Console.WriteLine("2.Dział pierwszy - koty");
                Console.WriteLine("3.Dział pierwszy - psy");

                ConsoleKeyInfo klawisz = Console.ReadKey();

                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        DzialPierwszy();
                        break;
                    case ConsoleKey.D2:
                        DzialDrugi();
                        break;
                    case ConsoleKey.D3:
                        DzialTrzeci();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        public static void DzialPierwszy()
        {
            Console.WriteLine("Hej Świnko");
            Console.ReadKey();
        }
        public static void DzialDrugi()
        {
            Console.WriteLine("Hej Kotku");
            Console.ReadKey();
        }
        public static void DzialTrzeci()
        {
            Console.WriteLine("Hej Piesku");
            Console.ReadKey();
        }

    }
}
