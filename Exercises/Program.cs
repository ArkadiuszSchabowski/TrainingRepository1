using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        //Wyswietl w konsoli prostokat o szerokosci x oraz dlugosci y, który zbydowany jest z ****.
        //X oraz Y podaje użytkownik
        static void Main(string[] args)
        {
            RandomNumber();
        }

        static void RandomNumber()
        {
            //Gra w zgadywanie liczby wylosowanej przez komputer
            //Komputer losuje liczbe z zakresu od 1-10
            //Jesli liczba wieksza mniejsza lub rowna nastepuja komunikaty

            Random rnd = new Random();
            int los = rnd.Next(1, 11);
            int mojaLiczba;
            int ileRazy = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Zgadnij liczbę z zakresu od 1-10: ");
                mojaLiczba = int.Parse(Console.ReadLine());
                if (mojaLiczba < 1 || mojaLiczba > 10)
                {
                    Console.WriteLine("Podałeś złą liczbę");
                }
                else
                    ileRazy++;
                {

                    if (mojaLiczba < los)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Twoja liczba jest za mała");
                    }
                    else if (mojaLiczba > los)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Twoja liczba jest za duża");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Brawo odgadłeś moją liczbę!!! Za {0} razem!", ileRazy);
                        Console.ReadKey();
                    }
                }
            } while (mojaLiczba != los);
        }
        static void Rectangle()
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("Podaj szerokość prostokąta");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość prostokąta");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
