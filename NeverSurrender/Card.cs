using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NeverSurrender
{
    public class FridayEvening
    {
        static void Main(string[] args)
        {
            int number;

            Random rnd = new Random();

            int los = rnd.Next(1, 11);

            Console.ForegroundColor = ConsoleColor.White;
            int ileRazy = 0;
            Console.WriteLine("Zgadnij liczbę z zakresu 1-10\n");

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 10 || number < 1)
                {
                    Console.WriteLine("Liczba z poza zakresu");
                }
                else
                {
                    ileRazy++;
                    if (number > los)
                    {
                        Console.WriteLine("Podałeś za duża liczbę");
                    }
                    else if (number < los)
                    {
                        Console.WriteLine("Podałeś za małą liczbę");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gratulacje");
                        Console.WriteLine($"Odgałeś moją liczbę za {ileRazy} razem");
                        Console.ReadKey();
                    }

                }
            }
            while (number != los);
        }
    }
}