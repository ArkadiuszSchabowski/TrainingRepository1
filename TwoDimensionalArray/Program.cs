using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] SwinskaTablica = new int[5] { 6, 5, 6, 5, 5 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(SwinskaTablica[i]);
            }
            Console.WriteLine("");

            TwoDimensialArray();
        }
        static void TwoDimensialArray()
        {
            int[,] PiggyBoard = new int[2, 3] {
                {6,6,3}, {3,3,3}
        };
            PiggyBoard[1, 2] = 5;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(PiggyBoard[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
