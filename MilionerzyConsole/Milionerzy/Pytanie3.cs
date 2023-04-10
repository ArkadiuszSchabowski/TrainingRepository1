using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    internal class Pytanie3
    {
        public static bool PytanieTrzecie()
        {
            string questionThree;

            Console.WriteLine("Gdy świnka jest szczęśliwa i czuję się bezpiecznie może zacząć?");
            Console.WriteLine("A - Popcornować");
            Console.WriteLine("B - Szybować");
            Console.WriteLine("C - Turlać się");
            Console.WriteLine("D - Freestylować\n");

            questionThree = Console.ReadLine();

            switch (questionThree)
            {
                case "A":
                    Console.WriteLine("Gratulacje to poprawna odpowiedź");
                    return true;
                case "B":
                    Console.WriteLine("Niestety to błędna odpowiedź");
                    return false;
                case "C":
                    Console.WriteLine("Niestety to błędna odpowiedź");
                    return false;
                case "D":
                    Console.WriteLine("Niestety to błędna odpowiedź");
                    return false;
            }
            return false;
        }
    }
}
