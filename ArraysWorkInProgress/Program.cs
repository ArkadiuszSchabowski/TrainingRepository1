using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWorkInProgress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zmienna1, zmienna2;

            zmienna1 = 5;
            zmienna2 = zmienna1;
            zmienna1 = 3;

            Console.WriteLine($"Zmienna1 powinna wynosić 3, a wynosi:{zmienna1}");
            Console.WriteLine($"Zmienna2 powinna wynosić 5, a wynosi:{zmienna2}\n");



            int[] tablica1 = new int[3] { 6, 10, 3 };
            int[] tablica2 = tablica1;
            tablica1[0] = 5;

            for (int i = 0; i < tablica1.Length; i++)
            {
                Console.Write("Tablica ocen1:");
                Console.WriteLine($"{tablica1[i]}");
            }
            Console.WriteLine("");
            for (int i = 0; i < tablica2.Length; i++)
            {
                Console.Write("Tablica ocen2:");
                Console.WriteLine($"{tablica2[i]}");
            }
            Console.ReadKey();
        }
    }
}