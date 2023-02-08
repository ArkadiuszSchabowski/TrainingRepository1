using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gradesArray = new int[10] { 5, 6, 2, 1, 3, 4, 4, 5, 2, 1 };
            for (int i = 0; i < gradesArray.Length; i++)
            {
                Console.WriteLine("index i " + i + " pozycja w tablicy " + (i + 1) + " ocena " + gradesArray[i]);
            }
            Console.ReadKey();
        }
    }
}
