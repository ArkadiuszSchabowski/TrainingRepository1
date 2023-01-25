using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Jaką chcesz kawę?");
                Console.WriteLine("1. Czarną");
                Console.WriteLine("2. Biała");
                Console.WriteLine("3.Koniec");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); OpcjaWBudowie(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); OpcjaWBudowie(); break;
                    case ConsoleKey.Escape: break;
                    case ConsoleKey.D3:
                        Environment.Exit(0); break;
                    default: break;
                }
                void OpcjaWBudowie()
                {
                    Console.Write("Opcja w budowie");
                    Console.ReadKey();
                }
            }
        }
    }
}
