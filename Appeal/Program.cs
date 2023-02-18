using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lotto();
            LadderHeight();
        }
        static void LadderHeight()
        {
            int LadderHeight;

            Console.WriteLine("Podaj wysokość drabiny");

            LadderHeight = int.Parse(Console.ReadLine());

            for (int i = 0; i < LadderHeight; i++)
            {
                for (int j = 0; j < LadderHeight; j++)
                {
                    if(i%2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if(j==0 || j == LadderHeight - 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Lotto()
        {
            int ileRazy = 0;
            int number, number2;

            Random rnd = new Random();

            number2 = rnd.Next(1, 11);

            Console.WriteLine("Zgadnij liczbę z zakresu 1-10");

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 10 || number < 1)
                {
                    Console.WriteLine("Liczba jest z poza zakresu!");
                }
                else
                {
                    ileRazy++;
                    if (number < number2)
                    {
                        Console.WriteLine("Twoja liczba jest za mała");
                    }
                    else if (number > number2)
                    {

                        Console.WriteLine("Twoja liczba jest za duża");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Gratulacje zgadłeś wymyśloną przeze mnie liczbę świnko za {ileRazy} razem!");
                        Console.ReadKey();
                    }
                }

            } while (number != number2);

        }
    }
}