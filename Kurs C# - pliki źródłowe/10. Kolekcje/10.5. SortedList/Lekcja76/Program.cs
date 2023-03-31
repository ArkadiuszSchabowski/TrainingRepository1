using System;
using System.Collections.Generic;

namespace Lekcja76
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Poniedziałek");
            sl.Add(2, "Wtorek");
            sl.Add(3, "Środa");
            sl.Add(4, "Czwartek");
            sl.Add(5, "Piątek");

            foreach (KeyValuePair<int, string> item in sl)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine("--------");
            Console.WriteLine(sl[1]);
            Console.WriteLine(sl.Values[0]);
            Console.WriteLine(sl.Keys[0]);
            Console.WriteLine("--------");

            foreach (var item in sl.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
