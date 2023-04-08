using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    internal class PytanieZa100
    {
        public static void PytaniePierwsze()
        {
            Random rnd = new Random();
            int firstQuestion;
            string questionOne = "";

            firstQuestion = rnd.Next(1, 3);
            Console.WriteLine("Pytanie 1");

            if (firstQuestion == 1)
            {
                Console.WriteLine("Na czym ściera zęby świnka morska");
                Console.WriteLine("A-Siano\n B-Marchewka\n C-Banan\n D-Gruszka");

                questionOne = Console.ReadLine();

                switch (questionOne)
                {
                    case "A":
                        Console.WriteLine("Gratulacje to poprawna odpowiedź");
                        break;
                    case "B":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                    case "C":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                    case "D":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                }
            }

            if (firstQuestion == 2)
            {

                Console.WriteLine("Ile powinna w przybliżeniu ważyć dorosła świnka morska");
                Console.WriteLine("A-1kg\n B-0,5kg\n C-2kg\n D-1,5kg");

                questionOne = Console.ReadLine();

                switch (questionOne)
                {
                    case "A":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                    case "B":
                        Console.WriteLine("Gratulacje to poprawna odpowiedź");
                        break;
                    case "C":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                    case "D":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                }
            }

            if (firstQuestion == 3)
            {
                Console.WriteLine("Jakiego dźwięku nie wydaje świnka morska");
                Console.WriteLine("A-Kwiczenie\n B-Gruchotanie\n C-Miauczenie\n D-Piszczenie");

                questionOne = Console.ReadLine();

                switch (questionOne)
                {
                    case "A":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                    case "B":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                    case "C":
                        Console.WriteLine("Gratulacje to poprawna odpowiedź");
                        break;
                    case "D":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        break;
                }
            }
        }
    }
}

