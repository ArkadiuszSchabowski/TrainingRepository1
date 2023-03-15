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
        }
        static void PodajLiczby()
        {
            int[] liczby = new int[6];
            Console.WriteLine("Podaj 6 liczb z zakresu 1-49");

            for (int i = 0; i < liczby.Length; i++)
            {
                bool result = true;
                int number;

                Console.WriteLine("Podaj liczbę {0}:", i +1);
                result = int.TryParse(Console.ReadLine(), out number);
                if (result && (number > 0 && number < 50) && !liczby.Contains(number))
                {
                    liczby[i] = number;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa liczba");
                    i--;
                }
            }
            Array.Sort(liczby);
            Console.WriteLine();
            foreach (var item in liczby)
            {
                Console.Write(item + ",");
            }
            Console.ReadKey();
        }
    }
}
