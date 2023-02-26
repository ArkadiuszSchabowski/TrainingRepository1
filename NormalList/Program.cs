using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 2, 3 };
            int numbersSum = 0;

            foreach (int number in numbers)
            {
                numbersSum += number;
            }

            double numbersAverage = (double)numbersSum / numbers.Length;
            Console.WriteLine(numbersAverage);
            Console.ReadKey();

            //List<int> numbersList = new List<int>() { 4, 5, 2, 3 };
            //double listAverage = numbersList.Average();
            //Console.WriteLine(listAverage);
            //Console.ReadKey();
        }
    }
}
