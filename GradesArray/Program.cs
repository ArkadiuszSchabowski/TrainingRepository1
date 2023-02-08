using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int[] NowaTablica = new int[10] { 3, 4, 5, 3, 2, 1, 6, 2, 2, 1 };
            for (int i = 0; i < NowaTablica.Length; i++)
            {
                Console.WriteLine("index " + i + " pozycja " + (i + 1) + " ocena " + NowaTablica[i]);
            }

            foreach (int elem in NowaTablica)
            {
                sum += elem;
            }

            Console.WriteLine("\nSuma ocen to " + sum);
            Console.WriteLine("\nŚrednia ocen to " + (sum / NowaTablica.Length));
            Console.ReadKey();
        }
    }
}
