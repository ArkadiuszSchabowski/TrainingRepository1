using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    public class Pytanie2
    {
        static int _secondQuestion;

        public static bool PytanieDrugie()
        {
            Random rnd = new Random();
            _secondQuestion = rnd.Next(1, 4);

            string questionTwo;

            if (_secondQuestion == 1)
            {
                Console.WriteLine("Pytanie 2. Jak Inaczej kiedyś nazywano świnkę morską?\n");
                Console.WriteLine("A - świnką miniaturową");
                Console.WriteLine("B - powiększonym chomikiem");
                Console.WriteLine("C - uszatniczką");
                Console.WriteLine("D - świnką nadmorską\n");

                questionTwo = Console.ReadLine();

                switch (questionTwo)
                {
                    case "A":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "B":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "C":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "D":
                        Console.WriteLine("Gratulacje to poprawna odpowiedź");
                        return true;
                }
                return false;
            }

            if (_secondQuestion == 2)
            {
                Console.WriteLine("Pytanie Nr 2. Jak inaczej inaczej nazwiemy świnkę o rasie Rozetka?");

                Console.WriteLine("A - Sheltie");
                Console.WriteLine("B - Dlugowłosą");
                Console.WriteLine("C - Abisyńską");
                Console.WriteLine("D - Krótkowłosą\n");

                questionTwo = Console.ReadLine();

                switch (questionTwo)
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

            if (_secondQuestion == 3)
            {

                Console.WriteLine("Pytanie Nr 2.Jaki powinien być najmniejszy rozmiar klatki przeznaczonej dla 2 świnek?");
                Console.WriteLine("A - 40cmx40cm");
                Console.WriteLine("B - 60cmx40cm");
                Console.WriteLine("C - 80cmx60cm");
                Console.WriteLine("D - 100cmx60cm\n");

                questionTwo = Console.ReadLine();

                switch (questionTwo)
                {
                    case "A":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "B":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "C":
                        Console.WriteLine("Niestety to błędna odpowiedź");
                        return false;
                    case "D":
                        Console.WriteLine("Gratulacje to poprawna odpowiedź");
                        return true;
                }
                return false;
            }
            return false;
        }
    }
}