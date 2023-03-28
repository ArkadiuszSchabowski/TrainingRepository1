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
        static int _age = 0;
        static int _weight = 0;
        static int _height = 0;

        static double _resultGenderSelection;
        static double _resultThePurposeOfTheDiet;

        static string genderSelection = null;
        static string thePurposeOfTheDiet = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w aplikacji: AUTOMATYCZNY GENERATOR DIETY!.\n");
            Console.WriteLine("Na podstawie danych, które podasz ułożymy Twoją dietę. Razem na pewno osiągniemy cel!");
            Console.WriteLine();
            Console.Write("Kliknij dowolny przycisk, aby przejść do generatora diet: ");
            Console.ReadKey();

            _resultGenderSelection = GenderSelection();

            if (_resultGenderSelection == 1)
            {
                genderSelection = "Kobieta";
            }
            if (_resultGenderSelection == 2)
            {
                genderSelection = "Mężczyzna";
            }

            UserInput();

            _resultThePurposeOfTheDiet = ThePurposeOfThediet();

            if (_resultThePurposeOfTheDiet == 1)
            {
                thePurposeOfTheDiet = "Zrzucenie wagi i redukcję tkanki tłuszczowej";
            }
            if (_resultThePurposeOfTheDiet == 2)
            {
                thePurposeOfTheDiet = "Wzrost siły i masy mięśniowej";
            }
            if (_resultThePurposeOfTheDiet == 3)
            {
                thePurposeOfTheDiet = "Poprawa jakości i proporcji ciała";
            }
            if (_resultThePurposeOfTheDiet == 4)
            {
                thePurposeOfTheDiet = "Poprawa Twojego stanu zdrowia";
            }

            TheUserCheckTheData();

        }
        static void TheUserCheckTheData()
        {
            Console.Clear();
            Console.WriteLine($"Sprawdź proszę swoje dane:\n\nPłeć: {genderSelection},\nWiek: {_age},\nWaga: {_weight},\nWzrost: {_height},\nCel diety: {thePurposeOfTheDiet}.\n");
            Console.WriteLine("Jeśli podane są poprawne kliknij dowolny przycisk, by przejść dalej.\nJeśli podane dane są niepoprawne to możesz uruchomić program ponownie.");

            Console.ReadKey();
        }
        static void UserInput()
        {
            bool result;

            Console.Clear();
            Console.WriteLine("Podaj swój wiek:");

            result = int.TryParse(Console.ReadLine(), out _age);

            if (result)
            {
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }

            Console.WriteLine("Podaj swoją wagę:");

            result = int.TryParse(Console.ReadLine(), out _weight);

            if (result)
            {
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }

            Console.WriteLine("Podaj swój wzrost");

            result = int.TryParse(Console.ReadLine(), out _height);
            if (result)
            {
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość");
            }
        }

        private static double GenderSelection()
        {
            ConsoleKey selection;

            Console.Clear();
            Console.WriteLine("Kliknij liczbę, aby wybrać swoją płeć:\n");

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
        private static double ThePurposeOfThediet()
        {
            ConsoleKey selection;

            Console.Clear();
            Console.WriteLine("Kliknij liczbę, aby wybrać cel diety:\n");
            Console.WriteLine("1. Redukcja masy tłuszczowej");
            Console.WriteLine("2. Wzrost siły i masy mięśniowej ");
            Console.WriteLine("3. Poprawa jakości ciała(wzrost masy mięśniowej, spadek masy tłuszczowej) przy utrzymaniu wagi");
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
