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
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);

            while (true)
            {
                Console.Write("Please fancy your value: ");
                int yourNumber;
                bool yourNumber_result = int.TryParse(Console.ReadLine(), out yourNumber);

                if (yourNumber_result == true)
                {
                    if (yourNumber == randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulations!!! You have guessed the number!!! ");
                        break;
                    }
                    else if (yourNumber < randomNumber)
                    {
                        Console.WriteLine("The number is greater than " + yourNumber);
                    }
                    else
                    {
                        Console.WriteLine("The number is less than " + yourNumber);
                    }
                }
                else
                {
                    Console.WriteLine("You have added incorrect value");
                }

            }
            Console.ReadKey();
        }
    }
}