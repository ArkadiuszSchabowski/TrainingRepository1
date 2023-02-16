using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            History();
            Liczba();
        }

        static void History()
        {
        }

        static void Liczba()
        {
            var Program = new Program();

            int a = 1;
            int b = 2;
            int liczba = a + b;
            Console.WriteLine(liczba);
            Console.ReadKey();
        }
    }
}