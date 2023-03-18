using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedenKupon
{
    internal class Program
    {
        static Random rnd = new Random();
        static int kumulacja;
        static int pieniadze = 50;
        static int dzien = 1;
        static void Main(string[] args)
        {
            int[] kupon = new int[6];
            int losow = 0;
            kumulacja = rnd.Next(2, 37) * 1000000;

            do
            {
                Console.Clear();
                Console.WriteLine("To Twój {0} dzień gry", dzien);
                Console.WriteLine("Twój stan portfela to: {0}zł.", pieniadze);
                Console.WriteLine($"Dzisiejsza kumulacja wynosi: {kumulacja}!");
                Console.WriteLine();
                if (losow == 0)
                {
                    Console.WriteLine("Nie postawiłeś jeszcze żadnych losów.\n");
                }
                else
                {
                    Console.WriteLine("Postawiłeś los. Postawionych losów: {0}/1.\n", losow);
                    WyswietlKupon(kupon);
                }

                Console.WriteLine("1 - Postaw kupon");
                Console.WriteLine("2 - Sprawdz Kupon");
                Console.WriteLine("3 - Zakoncz grę");

                ConsoleKey wybor = Console.ReadKey().Key;

                if (wybor == ConsoleKey.D1 && losow < 1 && pieniadze >= 3)
                {
                    int[] kupon1 = PostawKupon(kupon);
                    pieniadze -= 3;
                    losow++;

                    foreach (var item in kupon1)
                    {
                        Console.Write(item + ", ");
                    }
                    Console.ReadKey();
                }
                if (wybor == ConsoleKey.D2)
                {
                    dzien++;
                    int[] kupon2 = WylosowaneNumery(kupon);
                    Sprawdz(kupon, kupon2);
                }
                if (wybor == ConsoleKey.D3)
                {
                    Console.WriteLine("Zrezygnuj z dalszej gry");
                }
            } while (true);

        }

        private static void WyswietlKupon(int[] kupon1)
        {
            Console.Write("Kupon numer 1: ");
            foreach (var item in kupon1)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static int[] PostawKupon(int[] kupon)
        {
            bool check;
            int result;

            Console.Clear();
            Console.WriteLine("Podaj 6 liczb z zakresu 1-49:");
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Liczba {0}/6:", i);
                check = int.TryParse(Console.ReadLine(), out result);

                if (check && (result > 0 && result < 50) && !kupon.Contains(result))
                {
                    kupon[i - 1] = result;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa wartość");
                    i--;
                }
            } while (i < kupon.Length);
            Array.Sort(kupon);
            return kupon;
        }
        private static int[] WylosowaneNumery(int[] kupon)
        {
            int[] computerNumbers = new int[6];

            for (int i = 0; i < computerNumbers.Length; i++)
            {
                int number = rnd.Next(1, 50);
                if (!computerNumbers.Contains(number))
                {
                    computerNumbers[i] = number;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(computerNumbers);
            return computerNumbers;
        }
        private static int[] Sprawdz(int[] kupon1, int[] kupon2)
        {
            int[] trafione = new int[6];
            trafione[0] = 0;
            trafione[1] = 0;
            trafione[2] = 24;
            trafione[3] = 250;
            trafione[4] = 5000;
            trafione[5] = kumulacja;

            Console.Clear();
            Console.WriteLine($"LIczby z kuponu użytkownika to:");
            foreach (var item in kupon1)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine($"LIczby wylosowane przez komputer to:");
            foreach (var item2 in kupon2)
            {
                Console.Write(item2 + ", ");
            }

            Console.ReadKey();
            return trafione;
        }
    }
}
