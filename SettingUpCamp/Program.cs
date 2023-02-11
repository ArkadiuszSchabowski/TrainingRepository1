using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingUpCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            var sum = 0;

            for (int i = 0; i < 18; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            Console.WriteLine("Twoje liczby ciągu Fibonacciego to kolejno:\n");

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
                sum = sum + item;
            }
            Console.WriteLine($"\nSuma ciągu Fibonacciego 20 liczb wynosi: {sum}");

            Console.ReadKey();
        }
    }
}