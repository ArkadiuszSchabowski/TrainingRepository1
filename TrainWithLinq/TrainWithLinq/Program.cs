using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainWithLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without Linq
            //double sum = 0;
            List<int> oceny = new List<int>();
            oceny.Add(6);
            oceny.Add(4);
            oceny.Add(1);
            oceny.Add(4);
            oceny.Add(2);

            //for (int i = 0; i < oceny.Count; i++)
            //{
            //    sum += oceny[i];
            //}
            //Console.WriteLine();
            //double average = sum / oceny.Count;

            //Console.WriteLine("Twoja suma to: " + sum);
            //Console.WriteLine("Twoje srednia to " + average);
            //Console.ReadKey();

            //With Linq
            Console.WriteLine($"Twoja suma to {oceny.Sum()}");
            Console.WriteLine($"Twoja suma to {oceny.Average()}");
            Console.ReadKey();
        }
    }
}
