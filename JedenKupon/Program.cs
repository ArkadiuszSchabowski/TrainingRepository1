using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JedenKupon
{
    internal class Program
    {
        static Random rnd = new Random();
        static int kumulacja;
        static int start = 50;
        static int pieniadze = 50;
        static int dzien = 0;
        static void Main(string[] args)
        {
            kumulacja = rnd.Next(2, 37) * 1000000;
            int[] kupon = new int[6];
            bool flaga = true;
            int losow = 0;
            ConsoleKey wybor2;
            do
            {
                losow = 0;
                dzien = 1;
                pieniadze = start;

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
                        int[] wylosowane = WylosowaneNumery(kupon);
                        Sprawdz(kupon, wylosowane);
                    }
                    if (wybor == ConsoleKey.D3)
                    {
                        flaga = false;
                    }
                } while (flaga == true);

                Console.Clear();
                Console.WriteLine($"Zakończyłeś grę w {dzien} dzien");
                Console.WriteLine($"Twój wynik to: {pieniadze - start}zł");
                Console.WriteLine("Nacisnij Enter, by zagrac jeszcze raz");

                wybor2 = Console.ReadKey().Key;

            } while (wybor2 == ConsoleKey.Enter);
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
                int number = rnd.Next(1, 11);
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
        private static void Sprawdz(int[] kupon1, int[] kupon2)
        {
            int i = 0;
            int j = 0;

            int wygrana3 = 24;
            int wygrana4 = 250;
            int wygrana5 = 5000;

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
            do
            {
                if (kupon1[0] == kupon2[i])
                {
                    j++;
                }

                else if (kupon1[1] == kupon2[i])
                {
                    j++;
                }
                else if (kupon1[2] == kupon2[i])
                {
                    j++;
                }
                else if (kupon1[3] == kupon2[i])
                {
                    j++;
                }
                else if (kupon1[4] == kupon2[i])
                {
                    j++;
                }
                else if (kupon1[5] == kupon2[i])
                {
                    j++;
                }
                i++;
            } while (i < kupon1.Length);
            Console.WriteLine();
            Console.WriteLine();
            if (j == 6)
            {
                Console.WriteLine($"Trafiłeś {j} liczb!");
                Console.WriteLine($"Wygrałeś {kumulacja}zł! Gratulacje!");
                pieniadze += kumulacja;
            }
            else if (j == 5)
            {
                Console.WriteLine($"Trafiłeś {j} liczb!");
                Console.WriteLine($"Wygrałeś {wygrana5}zł! Gratulacje!");
                pieniadze += wygrana5;
            }
            else if (j == 4)
            {
                Console.WriteLine($"Trafiłeś {j} liczby!");
                Console.WriteLine($"Wygrałeś {wygrana4}zł! Gratulacje!");
                pieniadze += wygrana4;
            }
            else if (j == 3)
            {
                Console.WriteLine($"Trafiłeś {j} liczby!");
                Console.WriteLine($"Wygrałeś {wygrana3}zł! Gratulacje!");
                pieniadze += wygrana3;
            }
            else if (j == 2)
            {
                Console.WriteLine($"Trafiłeś {j} liczby!");
                Console.WriteLine("Niestety nic nie wygrałeś!");
            }
            else
            {
                Console.WriteLine($"Trafiłeś {j} liczb!");
                Console.WriteLine("Niestety nic nie wygrałeś!");
            }

            Console.ReadKey();
        }
    }
}
