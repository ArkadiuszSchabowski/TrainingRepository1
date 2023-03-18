using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NeverSurrender2
{
    internal class Program
    {
        static Random rnd = new Random();
        static int kumulacja = 0;
        static int start = 10;
        static int dzien = 1;
        static int pieniadze = start;
        static int kuponow;
        static void Main(string[] args)
        {
            bool isTrue = true;
            int i = 0;
            int[] kupon = new int[6];
            ConsoleKey wybor;
            ConsoleKey wybor2;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"To Twój {dzien} dzien gry.");
                    Console.WriteLine($"Twój stan konta wynosi {pieniadze}zł.");
                    WyswietlKupon(kupon);

                    Console.WriteLine();

                    Console.WriteLine("1 - Postaw Los");
                    Console.WriteLine("2 - Sprawdz Kupon");
                    Console.WriteLine("3 - Wyjscie");

                    wybor = Console.ReadKey().Key;

                    if (wybor == ConsoleKey.D1 && pieniadze >= 3 && kuponow < 1)
                    {
                        int[] kuponGracza = PostawKupon(kupon);
                        pieniadze -= 3;
                        kuponow++;
                       
                    }
                    if (wybor == ConsoleKey.D2)
                    {
                        SprawdzKupon(kupon);
                        dzien++;
                        kuponow = 0;
                    }
                    if (wybor == ConsoleKey.D3)
                    {
                        isTrue = false;
                    }
                    i++;
                } while (isTrue == true);


                Console.WriteLine($"Twój wynik to: {pieniadze - start}zł");
                Console.WriteLine("Jesli chcesz zagrać jeszcze raz naciśnij Enter");

                wybor2 = Console.ReadKey().Key;
            } while (wybor2 == ConsoleKey.Enter);
        }
        private static void WyswietlKupon(int[] kuponGracza)
        {
            if (kuponow == 0)
            {
                Console.WriteLine("Nie postawiono jeszcze kuponów.");
            }
            else
            {
                Console.WriteLine("Postawionych Kuponów {0}/1", kuponow);
                foreach (var item in kuponGracza)
                {
                    Console.Write(item + ",");
                }
            }
            Console.WriteLine();
        }
        private static void SprawdzKupon(int[] kuponGracza)
        {
            int[] computerNumbers = new int[6];
            int number = 0;

            for (int i = 0; i < computerNumbers.Length; i++)
            {
                number = rnd.Next(1, 50);
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
            Compare(kuponGracza, computerNumbers);
            Console.ReadKey();
        }
        private static int Compare(int[] liczbyGracza, int[] computerNumbers)
        {
            Console.Clear();
            int wygrana = 0;
            int j = 0;
            int wygrana3 = 24;
            int wygrana4 = 250;
            int wygrana5 = 500;
            int wygrana6 = kumulacja;

            Console.WriteLine("Liczby gracza:");
            foreach (var item in liczbyGracza)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Liczby wylosowane przez komputer:");
            foreach (var item in computerNumbers)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] a = liczbyGracza;
            int[] b = computerNumbers;
            for (int i = 0; i < liczbyGracza.Length; i++)
            {
                if (liczbyGracza[0] == computerNumbers[i])
                {
                    j++;
                }
                if (liczbyGracza[1] == computerNumbers[i])
                {
                    j++;
                }
                if (liczbyGracza[2] == computerNumbers[i])
                {
                    j++;
                }
                if (liczbyGracza[3] == computerNumbers[i])
                {
                    j++;
                }
                if (liczbyGracza[4] == computerNumbers[i])
                {
                    j++;
                }
                if (liczbyGracza[5] == computerNumbers[i])
                {
                    j++;
                }
            }
            if (j == 6)
            {
                Console.WriteLine("Brawo trafiłeś {0} liczb, wygrywasz {1}", j, wygrana6);
                pieniadze += wygrana6;
            }
            else if (j == 5)
            {
                Console.WriteLine("Brawo trafiłeś {0} liczb, wygrywasz {1}", j, wygrana5);
                pieniadze += wygrana5;
            }
            else if (j == 4)
            {
                Console.WriteLine("Brawo trafiłeś {0} liczb, wygrywasz {1}", j, wygrana4);
                pieniadze += wygrana4;
            }
            else if (j == 3)
            {
                Console.WriteLine("Brawo trafiłeś {0} liczb, wygrywasz {1}", j, wygrana3);
                pieniadze += wygrana3;
            }
            else
            {
                Console.WriteLine("Niestety nic nie wygrałeś, trafiłeś {0} liczb.", j);
            }
            return wygrana;
        }
        private static int[] PostawKupon(int[] kupon)
        {
            bool prawidlowa;
            int number = 0;

            for (int i = 0; i < kupon.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Wytypuj {0} liczbę z zakresu 1-49", i + 1);
                Console.WriteLine($"Postawione liczby:{kupon[0]},{kupon[1]}, {kupon[2]}, {kupon[3]}, {kupon[4]}, {kupon[5]}");
                prawidlowa = int.TryParse(Console.ReadLine(), out number);

                if (prawidlowa && number > 0 && number < 50 && !kupon.Contains(number))
                {
                    kupon[i] = number;
                }
                else
                {
                    i--;
                    Console.WriteLine("Nieprawidłowa wartość");
                    Console.ReadKey();
                }
            }
            Array.Sort(kupon);
            return kupon;
        }
    }
}
