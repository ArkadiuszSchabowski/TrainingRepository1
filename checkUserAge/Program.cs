using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkUserAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek");
            int wiek = int.Parse(Console.ReadLine());
            string wypiszWiek = wiek > 20 ? "masz więcej niż 20 lat" : "Masz 20 lub mniej lat";
            Console.WriteLine(wypiszWiek);
            Console.ReadKey();
            
        }
    }
}
