using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaZawierajacaTabele
{
    internal class Program
    {
        static public List<int[]> kupon = new List<int[]>();
        static void Main(string[] args)
        {
            WyswietlKupon(kupon);

            Console.ReadKey();
        }


        private static int[] PostawLos()
        {
            int[] liczby = new int[6];
            liczby[0] = 7;
            liczby[1] = 1;
            liczby[2] = 1;
            liczby[3] = 3;
            liczby[4] = 4;
            liczby[5] = 1;
            return liczby;

        }
        private static void WyswietlKupon(List<int[]> kupon)
        {
            int i = 0;

            if (kupon.Count == 0)
            {
                Console.WriteLine("Nie postawiłeś jeszcze żadnych losów\n");
            }
            else
            {
                Console.WriteLine("Twoje kupony: ");

                foreach (int[] los in kupon)
                {
                    i++;
                    Console.Write(i + ": ");
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