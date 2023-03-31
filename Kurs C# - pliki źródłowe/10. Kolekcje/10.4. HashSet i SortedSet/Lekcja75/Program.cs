using System;
using System.Collections.Generic;

namespace Lekcja75
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Poniedziałek");
            hs.Add("Wtorek");
            hs.Add("Wtorek");
            hs.Add("Środa");
            hs.Add("Czwartek");
            hs.Add("Piątek");
            hs.Add("Piątek");
            hs.Add("Piątek");

            Console.WriteLine(hs.Contains("Niedziela"));
            Console.WriteLine("\nHashSet - Ilość: " + hs.Count);

            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }

            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("Piątek");
            ss.Add("Sobota");
            ss.Add("Niedziela");
            ss.Add("Niedziela");
            ss.Add("Niedziela");
            ss.Add("Niedziela");

            Console.WriteLine("\nSortedSet - Ilość: " + ss.Count);

            foreach (var item in ss)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nOperacje:");

            //hs.UnionWith(ss);
            //hs.ExceptWith(ss);
            //hs.IntersectWith(ss);
            hs.SymmetricExceptWith(ss);

            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(hs.IsSubsetOf(hs));
            Console.WriteLine(hs.IsSupersetOf(hs));
        }
    }
}
