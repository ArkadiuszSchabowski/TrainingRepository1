using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Styczeń
{
    internal class Program
//Teraz, gdy znasz już różne typy liczbowe, napisz kod obliczający pole koła o danym promieniu - załóżmy w naszym przykladzie, że bedzie to` 2,50 centymetra.Pamiętaj, że obszar koła to promień podniesiony do kwadratu pomnożony przez PI.
    {
        static void doubleradius()
        {

            double r = 2.5*2.5;
            double pi = Math.PI;
            double kolo = r * pi;

            Console.WriteLine($"Pole koła wynosi: {kolo}!");
            Console.ReadKey();

        }
        
        static void Main(string[] args)
        {
        doubleradius();
        }
    }
}