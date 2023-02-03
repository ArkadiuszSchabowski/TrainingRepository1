using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Arkadiusz", "Anielka", "Felix" };
            Console.WriteLine();
            names.Add("Arkadiusz");
            names.Add("Bill");
            names.Remove("Anielka");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
                Console.WriteLine($"My name is {names[0]}");
                Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");
                Console.ReadKey();
            }
        }
    }
}