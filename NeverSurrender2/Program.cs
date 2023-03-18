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
        static int kumulacja;
        static int start = 50;
        static int dzien = 1;
        static void Main(string[] args)
        {
            ConsoleKey wybor;
            bool isTrue = true;
            int i = 0;
            int pieniadze = start;
            int[] kupon = new int[6];
            int kuponow = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"To Twój {dzien} dzien gry.");
                Console.WriteLine($"Twój stan konta wynosi {pieniadze}zł.");
                if (kuponow == 0)
                {
                    Console.WriteLine("Nie postawiono jeszcze kuponów.");
                }
                else
                {
                    Console.WriteLine("Postawionych Kuponów {0}/1", kuponow);
                    WyswietlKupon(kupon);
                }
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
                    kuponow--;
                }
                if (wybor == ConsoleKey.D3)
                {
                    isTrue = false;
                }
                i++;
            } while (isTrue == true);

        }

        private static void WyswietlKupon(int[] kuponGracza)
        {
            foreach (var item in kuponGracza)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }

        private static void SprawdzKupon(int[] kupon)
        {

        }

        private static int[] PostawKupon(int[] kupon)
        {
            bool prawidlowa;
            int number = 0;

            for (int i = 0; i < kupon.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Podaj {0} liczbę z zakresu 1-49", i + 1);
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
