using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSkills
{
    class RandomNumber
    {
        public void Game()
        {
            Random rnd = new Random();
            int los = rnd.Next(1, 11);
            int number;
            int ileRazy = 0;

            Console.WriteLine("Zgadnij liczbę, którą wylosował komputer z zakresu od 1-10");

            do
            {
                number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Liczba z poza zakresu!");
                }
                else
                {
                    ileRazy++;
                    if (number < los)
                    {
                        Console.WriteLine("Twoja liczba jest za mała!");
                    }
                    else if (number > los)
                    {
                        Console.WriteLine("Twoja liczba jest za duża!");
                    }
                    else
                    {
                        Console.WriteLine($"Gratulacje zgadłeś liczbę za: {ileRazy} razem!");
                    }
                }

            } while (los != number);


            Console.ReadKey();

        }
    }
}
