using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListaZawierajacaTabele
{
    internal class Program
    {

        static int kumulacja;
        static int pieniadze;
        static int start = 50;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            ConsoleKey wybor;
            ConsoleKey wybor2;
            bool isTrue = true;
            pieniadze = start;
            int kuponow = 0;
            int dzien = 0;
            List<int[]> kupon = new List<int[]>();

            do
            {
                Console.Clear();
                pieniadze = start;
                kumulacja = rnd.Next(2, 37) * 1000000;
                dzien = 0;
                dzien++;

                do
                {
                    Console.Clear();
                    Console.WriteLine($"To Twój {dzien} dzien gry.");
                    Console.WriteLine($"Twój stan konta wynosi: {pieniadze}zł");
                    Console.WriteLine($"Dzisiejsza kumulacja wynosi {kumulacja}zł");
                    WyswietlKupon(kupon);
                    Console.WriteLine();


                    Console.WriteLine($"1 - Postaw Kupon. Postawionych kuponów {kuponow}/5");
                    Console.WriteLine("2 - Sprawdz Kupon");
                    Console.WriteLine("3 - Zakoncz gre");

                    wybor = Console.ReadKey().Key;

                    if (wybor == ConsoleKey.D1 && kuponow < 5 && pieniadze >= 3)
                    {
                        kupon.Add(PostawKupon());
                        pieniadze -= 3;
                        kuponow++;
                    }
                    if (wybor == ConsoleKey.D2)
                    {
                        dzien++;
                        WylosowaneLiczby(kupon);
                    }
                    if (wybor == ConsoleKey.D3)
                    {
                        isTrue = false;
                    }

                } while (pieniadze >= 3 && isTrue == true);

                Console.Clear();
                Console.WriteLine($"Zakończyłeś grę w {dzien} dzien");
                Console.WriteLine($"Twój wynik to: {pieniadze - start}zł");
                Console.WriteLine("Naciśnij Escape, aby zakończyć lub inny dowolny klawisz by grać dalej");
                wybor2 = Console.ReadKey().Key;

            } while (wybor2 != ConsoleKey.Escape);

        }

        private static void WyswietlKupon(List<int[]> kupon)
        {
            int i = 0;
            if (kupon.Count == 0)
            {
                Console.WriteLine("Nie postawiono jeszcze żadnych kuponów");
            }
            else
            {
                Console.WriteLine("Twoje kupony to: ");
            }
            foreach (int[] los in kupon)
            {
                i++;
                Console.Write(i + ": ");
                foreach (var liczba in los)
                {
                    Console.Write(liczba + ", ");
                }
                Console.WriteLine();
            }
        }

        private static int WylosowaneLiczby(List<int[]> kupon)
        {
            Console.Clear();
            int wygrana = 0;
            int[] computerNumbers = new int[6];
            int number = 0;
            int j = 0;

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
            Console.WriteLine("Liczby wylosowane przez komputer to:");
            Array.Sort(computerNumbers);
            foreach (var item in computerNumbers)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kupony użytkownika:");

            foreach (int[] los in kupon)
            {
                j++;
                Console.Write(j + ": ");
                foreach (var liczba in los)
                {
                    Console.Write(liczba + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return wygrana;
        }
        private static int[] PostawKupon()
        {
            bool result;
            int number;
            Console.Clear();
            Console.WriteLine("Wytypuj sześć liczb z przedziału 1-49");

            int[] userNumbers = new int[6];

            for (int i = 0; i < userNumbers.Length; i++)
            {
                result = int.TryParse(Console.ReadLine(), out number);
                if (result && number > 0 && number < 50 && !userNumbers.Contains(number))
                {
                    userNumbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa wartość");
                    i--;
                }
            }
            Console.Clear();
            Array.Sort(userNumbers);
            return userNumbers;
        }
    }
}