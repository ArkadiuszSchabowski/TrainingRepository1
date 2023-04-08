using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    public class Pytanie1
    {
        static int _firstQuestion;

        public static bool PytaniePierwsze()
        {
            Random rnd = new Random();
            string questionOne = "";

            _firstQuestion = rnd.Next(1, 4);
            Console.WriteLine("Pytanie 1");

            if (_firstQuestion == 1)
            {
                Console.WriteLine("Na czym ściera zęby świnka morska");
                Console.WriteLine("A-Siano\n B-Marchewka\n C-Banan\n D-Gruszka");

                questionOne = Console.ReadLine();

                switch (questionOne)
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

            if (_firstQuestion == 2)
            {

                Console.WriteLine("Ile powinna w przybliżeniu ważyć dorosła świnka morska");
                Console.WriteLine("A-0,5kgkg\n B-1kg\n C-2kg\n D-1,5kg");

                questionOne = Console.ReadLine();

                switch (questionOne)
                {
                    case "A":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "B":
                        Console.WriteLine("Gratulacje to poprawna odpowiedź");
                        return true;
                    case "C":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "D":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                }
                return false;
            }

            if (_firstQuestion == 3)
            {
                Console.WriteLine("Jakiego dźwięku nie wydaje świnka morska");
                Console.WriteLine("A-Kwiczenie\n B-Gruchotanie\n C-Miauczenie\n D-Piszczenie");

                questionOne = Console.ReadLine();

                switch (questionOne)
                {
                    case "A":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "B":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "C":
                        Console.WriteLine("Gratulacje to poprawna odpowiedź");
                        return true;
                    case "D":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                }
                return false;
            }
            Console.WriteLine("Niepoprawna wartość zmiennej _firstQuestion");
            return false;
        }
    }
}

