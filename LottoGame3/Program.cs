﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kumulacja;
            int pieniadze;
            int start = 30;
            int dzien = 0;
            Random rnd = new Random();
            do
            {
                pieniadze = start;
                dzien = 0;
                ConsoleKey wybor;
                do
                {
                    kumulacja = rnd.Next(2, 37) * 1000000;
                    dzien++;
                    int losow = 0;
                    List<int[]> kupon = new List<int[]>();
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Dzień {0}", dzien);
                        Console.WriteLine("Witaj w grze Lotto dziś do wygrania aż {0}zł!", kumulacja);
                        Console.WriteLine("\nStan konta {0}zł", pieniadze);
                        WyswietlKupon(kupon);
                        //Menu
                        if (pieniadze >= 3 && losow <= 8)
                        {
                            Console.WriteLine("1 - Postaw los - 3zł [{0}/8]", losow + 1);
                            Console.WriteLine("2 - Sprawdz kupon - losowanie");
                            Console.WriteLine("3 - Zakończ grę");
                        }
                        // Menu
                        wybor = Console.ReadKey().Key;
                        if (wybor == ConsoleKey.D1 && pieniadze >= 3 && losow < 8)
                        {
                            kupon.Add(PostawLos());
                            pieniadze -= 3;
                            losow++;
                        }
                    } while (wybor == ConsoleKey.D1);
                    Console.Clear();
                    if (kupon.Count > 0)
                    {
                        int wygrana = Sprawdz(kupon);
                        if (wygrana > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Brawo wygrałeś {0}zł w tym losowaniu!", wygrana);
                            Console.ResetColor();
                            pieniadze += wygrana;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Niestety, nic nie wygrałeś");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie miałeś losów w tym losowaniu!");
                    }
                    Console.WriteLine("Enter - kontynuuj.");
                    Console.ReadKey();
                } while (pieniadze >= 3 && wybor != ConsoleKey.D3);
                Console.Clear();
                Console.WriteLine("Zakończyłeś swoją grę w {0}, Twój wynik to {1}.", dzien, pieniadze - start);
                Console.WriteLine("Enter - graj od nowa.");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        private static int Sprawdz(List<int[]> kupon)
        {

            int wygrana = 0;
            int[] wylosowane = new int[6];

            for (int i = 0; i < wylosowane.Length; i++)
            {
                Random rnd = new Random();
                int los = rnd.Next(1, 50);
                if (!wylosowane.Contains(los))
                {
                    wylosowane[i] = los;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(wylosowane);
            Console.Write("Wylosowane liczby to: ");
            foreach (int liczba in wylosowane)
            {
                Console.Write(liczba + "'");
            }
            int[] trafione = SprawdzKupon(kupon, wylosowane);
            int wartosc = 0;
            Console.WriteLine();
            if (trafione[0] > 0)
            {
                wartosc = trafione[0] * 24;
                Console.WriteLine("3 Trafienia: {0}+{1}zł", trafione[0], wartosc);
                wygrana += wartosc;
            }
            if (trafione[1] > 0)
            {
                Random rnd = new Random();
                wartosc = trafione[1] * rnd.Next(100, 301);
                Console.WriteLine("4 Trafienia: {0}+{1}zł", trafione[1], wartosc);
                wygrana += wartosc;
            }
            if (trafione[2] > 0)
            {
                Random rnd = new Random();
                wartosc = trafione[2] * rnd.Next(4000, 8001);
                Console.WriteLine("5 Trafienia: {0}+{1}zł", trafione[2], wartosc);
                wygrana += wartosc;
            }
            if (trafione[3] > 0)
            {
                Random rnd = new Random();
                int kumulacja = rnd.Next(2, 37) * 1000000;
                wartosc = (trafione[3] * kumulacja) / trafione[3] + rnd.Next(1, 5);
                Console.WriteLine("6 Trafien: {0}+{1}zł", trafione[3], wartosc);
                wygrana += wartosc;
            }
            Console.WriteLine();

            return wygrana;
        }

        private static int[] SprawdzKupon(List<int[]> kupon, int[] wylosowane)
        {
            int[] wygrane = new int[4];
            int i = 0;
            Console.Write("Twój kupon: ");
            foreach (int[] los in kupon)
            {
                i++;
                Console.Write(i + ": ");
                int trafien = 0;
                foreach (int liczba in los)
                {
                    if (wylosowane.Contains(liczba))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(liczba + ";");
                        Console.ResetColor();
                        trafien++;
                    }
                    else
                    {
                        Console.Write(liczba + ",");
                    }
                }
                switch (trafien)
                {
                    case 3:
                        wygrane[0]++;
                        break;
                    case 4:
                        wygrane[1]++;
                        break;
                    case 5:
                        wygrane[2]++;
                        break;
                    case 6:
                        wygrane[3]++;
                        break;
                }
                Console.WriteLine(" - Trafiono z {0}/6", trafien);
            }
            return wygrane;
        }

        private static int[] PostawLos()
        {
            int[] liczby = new int[6];
            int liczba = -1;
            for (int i = 0; i < liczby.Length; i++)
            {
                liczba = -1;
                Console.Clear();
                Console.Write("Postawione liczby: ");
                foreach (int l in liczby)
                {
                    if (l > 0)
                    {
                        Console.WriteLine(l + ", ");
                    }
                }
                Console.WriteLine("\nWybierz liczby od 1 do 49:");
                Console.Write("{0}/6: ", i + 1);
                bool prawidlowa = int.TryParse(Console.ReadLine(), out liczba);
                if (prawidlowa && liczba >= 1 && liczba <= 49 && !liczby.Contains(liczba))
                {
                    liczby[i] = liczba;
                }
                else
                {
                    Console.WriteLine("Niestety błędna liczba");
                    i--;
                    Console.ReadKey();
                }
            }
            Array.Sort(liczby);
            return liczby;
        }

        private static void WyswietlKupon(List<int[]> kupon)
        {
            if (kupon.Count == 0)
            {
                Console.WriteLine("\nNie postawiłeś jeszcze żadnych losów");
            }
            else
            {
                int i = 0;
                Console.WriteLine("\nTwój kupon:");
                foreach (int[] los in kupon)
                {
                    i++;
                    Console.WriteLine(i + ": ");
                    foreach (int liczba in los)
                    {
                        Console.Write(liczba + ",");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
