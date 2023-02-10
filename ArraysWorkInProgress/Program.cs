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
            int[] TablicaSwinkowa = new int[4] { 6, 3, 4, 2 };
            Console.WriteLine("Tablica Swinska " + TablicaSwinkowa[0]);

            for (int i = 0; i < TablicaSwinkowa.Length; i++)
            {
                Console.WriteLine("Index:" + i + " Element tablicy:" + (i + 1) + " Swinska ocena:" + TablicaSwinkowa[i]);
            }
            Console.ReadKey();
        }
    }
}