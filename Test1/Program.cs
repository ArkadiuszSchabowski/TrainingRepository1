using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{

    //Stwórz prostokąt o dowolnych wymiarach zapisany symbolem *.
    internal class Program
    {
        static void Main(string[] args)
        {
            int szerokosc, dlugosc;

            Console.WriteLine("Wprowadź szerokosc prostokąta");
            szerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź długość prostokąta");
            dlugosc = int.Parse(Console.ReadLine());

            Console.WriteLine("Szerokosc Twojego prostokąta to: " + szerokosc + "." + " Dlugosc Prostokoąta to: " + dlugosc + ".");

            for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}