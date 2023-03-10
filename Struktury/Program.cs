using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    enum PoryRoku : sbyte
    {
        Wiosna =15, Lato=25, Jesień=25, Zima=-5
    }
    class Program
    {
        static void Main(string[] args)
        {
            PoryRoku poraRoku = (PoryRoku)25;
            Console.WriteLine(poraRoku);
            Console.ReadKey();
        }
    }
}