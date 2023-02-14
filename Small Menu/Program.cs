using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Twoje Małe Menu\n");

                Console.WriteLine("1.Rodzaje świnek morskich");
                Console.WriteLine("2.Pokarm dla świnek morskich");
                Console.WriteLine("3. Odgłosy świnek morskich\n");

                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nRodzaje świnek morskich\n");
                    Console.WriteLine("1.Świnka krótkowłosa");
                    Console.WriteLine("2.Świnka długowłosa");
                    Console.WriteLine("3.Peruwianka");

                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.WriteLine("Twój wybór to świnka krótkowłosa");
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.WriteLine("Twój wybór to świnka długowłosa");
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D3)
                    {
                        Console.WriteLine("Twój wybór to peruwianka");
                    }

                }
                else if (Console.ReadKey().Key == ConsoleKey.D2)
                {

                    Console.WriteLine("\nPokarm dla świnek morskich\n");
                    Console.WriteLine("1.Siano");
                    Console.WriteLine("2.Karma");
                    Console.WriteLine("3.Owoce i warzywa");

                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.WriteLine("Twój wybór to siano");
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.WriteLine("Twój wybór to karma");
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D3)
                    {
                        Console.WriteLine("Twój wybór to owoce i warzywa");
                    }
                    else
                    {
                        Console.WriteLine("Niewłaściwa operacja");
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.D3)
                {
                    Console.WriteLine("\nOdgłosy świnek morskich");
                    Console.WriteLine("1.Jestem głodna");
                    Console.WriteLine("2.Daj mi spokój");
                    Console.WriteLine("3.Zejdź mi z drogi!");
                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.WriteLine("Odgłos: jestem głodna");
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.WriteLine("Odgłos: daj mi spokój");
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D3)
                    {
                        Console.WriteLine("Odgłos: zejdź mi z drogi");
                    }
                    else
                    {
                        Console.WriteLine("Niewłaściwa operacja");
                    }
                }
                else
                {
                    Console.WriteLine("Niewłaściwa operacja");
                    Console.ReadKey();
                }
            }

        }
    }
}
