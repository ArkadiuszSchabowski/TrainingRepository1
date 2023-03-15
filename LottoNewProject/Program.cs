using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoNewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PodajLiczby();
            WylosujLiczby();
            SprawdzLiczby();
        }

        private static void SprawdzLiczby()
        {
        }

        private static void WylosujLiczby()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 50);
            int[] computerNumbers = new int[6];


            for (int  i = 0;  i < computerNumbers.Length;  i++)
            {
                int los = rnd.Next(1, 50);
                if (!computerNumbers.Contains(los))
                {
                    computerNumbers[i] = los;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(computerNumbers);
            Console.WriteLine("\n\nLiczby wylosowane przez komputer to: ");
            foreach (var item in computerNumbers)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static void PodajLiczby()
        {
            int[] userNumbers = new int[6];
            Console.WriteLine("Podaj 6 liczb z zakresu 1-49\n");

            for (int i = 0; i < userNumbers.Length; i++)
            {
                bool result = true;
                int number;

                Console.WriteLine("Podaj liczbę {0}:", i +1);
                result = int.TryParse(Console.ReadLine(), out number);
                if (result && (number > 0 && number < 50) && !userNumbers.Contains(number))
                {
                    userNumbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa liczba");
                    i--;
                }
            }
            Array.Sort(userNumbers);
            Console.WriteLine();
            Console.WriteLine("Twoje liczby to:");
            foreach (var item in userNumbers)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
    }
}
