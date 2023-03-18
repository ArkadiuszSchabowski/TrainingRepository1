using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastLottoProject
{
    internal class Program
    {
        static int kumulacja = 0;
        static int start = 50;
        static int dzien = 1;
        static void Main(string[] args)
        {

            ConsoleKey wybor;
            bool isTrue = true;
            int[] kupon = new int[6];
            int pieniadze;
            pieniadze = start;
            int losow = 0;
            int i = 1;

            do
            {
                Console.Clear();
                Console.WriteLine($"Dzień {dzien}");
                Console.WriteLine($"Twój stan konta do gry to: {pieniadze}zł");
                if (losow == 0)
                {
                    Console.WriteLine("Nie postawiłeś jeszcze żadnego kuponu");
                }
                else if(losow > 0)
                {
                    Console.WriteLine("Postawionych kuponów {0}/1.", losow);
                    WyswietlKupon(kupon);
                }

                Console.WriteLine();
                Console.WriteLine("1-Postaw Kupon");
                Console.WriteLine("2-Sprawdz Kupon");
                Console.WriteLine("3-Zakoncz grę");

                wybor = Console.ReadKey().Key;

                if (wybor == ConsoleKey.D1 && pieniadze >= 3 && losow < 1)
                {
                    pieniadze -= 3;
                    losow++;
                    int[] liczbygracza = PostawKupon(kupon);
                }
                if (wybor == ConsoleKey.D2)
                {
                    dzien++;
                    SprawdzKupon(kupon);
                }
                if (wybor == ConsoleKey.D3)
                {
                    isTrue = false;
                }
                i++;
            } while (pieniadze >= 3 && isTrue == true);

        }

        private static void WyswietlKupon(int[] liczbygracza)
        {
            foreach (var item in liczbygracza)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] PostawKupon(int[] kupon)
        {
            bool prawidlowa;
            int number;

            Console.Clear();
            Console.WriteLine("Podaj 6 liczb z przedziału 1-49");
            for (int i = 0; i < kupon.Length; i++)
            {
                prawidlowa = int.TryParse(Console.ReadLine(), out number);
                if (prawidlowa && number > 0 && number < 50 && !kupon.Contains(number))
                {
                    kupon[i] = number;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa wartość!");
                    i--;
                }
            }
            Array.Sort(kupon);
            return kupon;
        }

        private static void SprawdzKupon(int[] kupon)
        {

        }
    }
}
