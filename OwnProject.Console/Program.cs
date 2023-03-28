using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OwnProjectConsole
{
    //2.Rodzaj i częstotliwość aktualnie wykonywanej aktywności fizycznej lub jej brak?
    //6.Rodzaj wykonywanej pracy(fizyczna, umysłowa)?
    //9.Jakie są produkty, których nie chciałabyś/ chciałbyś w diecie?
    //10.Jaki efekt chciałabyś/ chciałbyś osiągnąć?

    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            int weight = 0;
            int height = 0;

            double resultGenderSelection;
            double resultThePurposeOfTheDiet;
            string genderSelection = null;
            string thePurposeOfTheDiet = null;

            Console.WriteLine("Witaj w aplikacji: AUTOMATYCZNY GENERATOR DIETY!.\n");
            Console.WriteLine("Na podstawie danych, które podasz ułożymy Twoją dietę. Razem na pewno osiągniemy cel!");
            Console.WriteLine();
            Console.Write("Kliknij dowolny przycisk, aby przejść do generatora diet:");
            Console.ReadKey();

            resultGenderSelection = GenderSelection();

            UserData(age, weight, height);

            if (resultGenderSelection == 1)
            {
                genderSelection = "Kobieta";
            }
            if (resultGenderSelection == 2)
            {
                genderSelection = "Mężczyzna";
            }

            resultThePurposeOfTheDiet = ThePurposeOfThediet();

            if (resultThePurposeOfTheDiet == 1)
            {
                thePurposeOfTheDiet = "Dieta na zrzucenie wagi i redukcję tkanki tłuszczowej";
            }
            if (resultThePurposeOfTheDiet == 2)
            {
                thePurposeOfTheDiet = "Dieta na wzrost siły i masy mięśniowej";
            }
            if (resultThePurposeOfTheDiet == 3)
            {
                thePurposeOfTheDiet = "Dieta poprawiająca jakość i proporcję ciała";
            }
            if (resultThePurposeOfTheDiet == 4)
            {
                thePurposeOfTheDiet = "Dieta, która poprawi Twój stan zdrowia";
            }

            Console.WriteLine($"Sprawdź proszę swoje dane: {age}, {weight}, {height}, {genderSelection}, {thePurposeOfTheDiet}.");
            Console.ReadKey();

        }
        private static double GenderSelection()
        {
            ConsoleKey selection;

            Console.Clear();
            Console.WriteLine("Kliknij liczbę, aby wybrać swoją płeć\n");

            Console.WriteLine("1. Kobieta");
            Console.WriteLine("2. Mężczyzna\n");

            switch (selection = Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Kobieta");
                    return 1;
                case ConsoleKey.D2:
                    Console.WriteLine("Mężczyzna\n");
                    return 2;
            }
            return 0;
        }
        private static double UserData(int age, int weight, int height)
        {
            bool result;

            Console.Clear();
            Console.WriteLine("Podaj swój wiek");

            result = int.TryParse(Console.ReadLine(), out age);

            if (result)
            {
                return age;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }

            Console.WriteLine("Podaj swoją wagę");

            result = int.TryParse(Console.ReadLine(), out weight);

            if (result)
            {
                return weight;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }

            Console.WriteLine("Podaj swój wzrost");

            result = int.TryParse(Console.ReadLine(), out height);
            if (result)
            {
                return height;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }
            return 0;
        }
        private static double ThePurposeOfThediet()
        {
            ConsoleKey selection;

            Console.Clear();
            Console.WriteLine("Kliknij liczbę, aby wybrać cel diety\n");
            Console.WriteLine("1. Redukcja masy tłuszczowej");
            Console.WriteLine("2. Wzrost siły i masy mięśniowej ");
            Console.WriteLine("3.Poprawa jakości ciała(wzrost masy mięśniowej, spadek masy tłuszczowej) przy utrzymaniu wagi");
            Console.WriteLine("4. Poprawa stanu zdrowia\n");

            switch (selection = Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.D3:
                    return 3;
                case ConsoleKey.D4:
                    return 4;
            }
            return 0;
        }
    }
}
