using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18MarchLotto
{
    internal class Program
    {
        static int kumulacja;
        static int pieniadze = 50;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            ConsoleKey wybor;
            int losow = 0;
            List<int[]> kupon = new List<int[]>();
            do
            {
                kumulacja = rnd.Next(1, 37) * 1000000;
                Console.WriteLine("Dzisiejsza kumulacja wynosi {0}zł", kumulacja);
                do
                {
                    int dzien = 0;
                    dzien++;
                    Console.WriteLine("Witaj w grze Lotto!");
                    Console.WriteLine("To Twój {0} dzień gry.", dzien);
                    Console.WriteLine("Twój stan konta wynosi: {0}zł.", pieniadze);
                    WyswietlKupon(kupon);
                    Console.ReadKey();

                    Console.WriteLine("1 - Postaw kupon. Postawionych kuponów {0}/5", losow);
                    Console.WriteLine("2 - Sprawdz kupon");
                    Console.WriteLine("3 - Koniec gry");

                    wybor = Console.ReadKey().Key;

                    if (wybor == ConsoleKey.D1 && pieniadze >= 3 && losow < 5)
                    {
                        pieniadze -= 3;
                        losow++;
                        kupon.Add(PostawKupon());
                    }
                    if (wybor == ConsoleKey.D2)
                    {
                        SprawdzKupon();
                    }
                    if (wybor == ConsoleKey.D3)
                    {

                    }
                } while (pieniadze >= 3 && wybor != ConsoleKey.D3);

            } while (true);
        }

        private static void WyswietlKupon(List<int[]> kupon)
        {
            if (kupon.Count == 0)
            {
                Console.WriteLine("Nie postawiłeś jeszcze żadnych kuponów");
            }
            else
            {
                
            }
        }
    


    private static void SprawdzKupon()
    {
        int[] liczbyKomputera = new int[6];
        int liczba;

        for (int i = 0; i < liczbyKomputera.Length; i++)
        {
            liczba = rnd.Next(1, 50);
            if (!liczbyKomputera.Contains(liczba))
            {
                liczbyKomputera[i] = liczba;
            }
            else
            {
                i--;
            }
        }
        Array.Sort(liczbyKomputera);
        Console.WriteLine();
        foreach (var item in liczbyKomputera)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }

    private static int[] PostawKupon()
    {
        Console.WriteLine("Podaj 6 liczb z przedziału 1-49");
        int[] liczbyGracza = new int[6];
        int numer = 0;
        bool result;

        for (int i = 0; i < liczbyGracza.Length; i++)
        {
            Console.WriteLine($"Podaj {i + 1} liczbę:");
            result = int.TryParse(Console.ReadLine(), out numer);

            if (result && numer > 0 && numer < 50 && !liczbyGracza.Contains(numer))
            {
                liczbyGracza[i] = numer;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
                i--;
            }

        }
        Array.Sort(liczbyGracza);
        Console.WriteLine();
        foreach (var item in liczbyGracza)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
        return liczbyGracza;
    }
}
}
