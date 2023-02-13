using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzybkiProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Lista();
        }
        private static void Lista()
        {
            var names = new List<string> {"Arkadiusz", "Beata", "Dominika" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}");
            }
            Console.WriteLine("Wybierz dział:");
            Console.ReadKey();

        }
    }
}
