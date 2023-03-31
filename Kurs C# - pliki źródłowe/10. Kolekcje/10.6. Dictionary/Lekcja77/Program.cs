using System;
using System.Collections.Generic;

namespace Lekcja77
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Poniedziałek");
            dictionary.Add(2, "Wtorek");
            dictionary.Add(3, "Środa");
            dictionary.TryAdd(3, "Środa");

            //Console.WriteLine(dictionary[1]);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();

            sd.Add(5, "Piątek");
            sd.Add(4, "Czwartek");

            foreach (var item in sd)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
