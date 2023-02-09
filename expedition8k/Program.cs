using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace expedition8k
{
    internal class Program
    {
        //Teraz, gdy znasz już różne typy liczbowe, napisz kod obliczający pole koła o danym promieniu - załóżmy w naszym przykladzie, że bedzie to` 2,50 centymetra.Pamiętaj, że obszar koła to promień podniesiony do kwadratu pomnożony przez PI.

        //.NET zawiera stałą dla PI, Math.PI, której można użyć dla tej wartości. Math.PI, podobnie jak wszystkie stałe zadeklarowane w przestrzeni nazw System.Math, jest wartością podwójną.
        //W tym zadaniunależy używać wartości double zamiast wartości int. Powinieneś otrzymać odpowiedź między 19 a 20.

        //Teraz przenieś kod do osobnej metody z parametrem "double radius" i koniecznie podziel się swoim kodem w naszej grupie na FB
        static void Main(string[] args)
        {
            DoubleRadius();
        }
        static void DoubleRadius()
        {
            double r, obszarKola, poleKola, pi;

            r = 2.5;
            obszarKola = r * r;
            pi = Math.PI;
            poleKola = obszarKola * pi;

            //Console.WriteLine("Pole naszego koła po zaokrągleniu wynosi: " + Math.Round(poleKola, 2));
            ////Zapis numer1

            Console.WriteLine($"Pole naszego koła po zaokrągleniu wynosi: {Math.Round(poleKola, 2)}");
            //Zapis numer2

            Console.ReadKey();
        }
    }
}