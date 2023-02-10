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