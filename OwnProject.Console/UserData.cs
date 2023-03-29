using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProjectConsole
{
    public class UserData
    {
        static int _age = 0;
        static int _weight = 0;
        static int _height = 0;

        static double _resultGenderSelection;
        static double _resultThePurposeOfTheDiet;
        static int _resultKindOfTheWork;
        static int _resultHowManyTimesYouTrain;

        static string genderSelection = null;
        static string thePurposeOfTheDiet = null;
        static string kindOfTheWork = null;
        static string howManyTimesYouTrain = null;
        public static void MainUserData()
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

            _resultKindOfTheWork = KindOfTheWork();

            if (_resultKindOfTheWork == 1)
            {
                kindOfTheWork = "Praca fizyczna";
            }
            if (_resultKindOfTheWork == 2)
            {
                kindOfTheWork = "Praca umysłowa";
            }
            _resultHowManyTimesYouTrain = HowManyTimesYouTrain();

            if (_resultHowManyTimesYouTrain == 1)
            {
                howManyTimesYouTrain = "Brak aktywnośi fizycznej";
            }
            if (_resultHowManyTimesYouTrain == 2)
            {
                howManyTimesYouTrain = "Umiarkowana aktywność fizyczna";
            }
            if (_resultHowManyTimesYouTrain == 3)
            {
                howManyTimesYouTrain = "Duża aktywność fizyczna";
            }
            TheUserCheckTheData();
        }
        public static int HowManyTimesYouTrain()
        {
            ConsoleKey selection;

            Console.Clear();
            Console.WriteLine("Ile razy w tygodniu trenujesz?:\n");

            Console.WriteLine("1. Brak aktywności fizycznej - jeszcze nie trenuję");
            Console.WriteLine("2. Umiarkowna aktywność fizyczna - trenuję 1-3 razy");
            Console.WriteLine("3. Duża aktywność fizyczna - wiecęj niż 3xtygodniowo");

            switch (selection = Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.D3:
                    return 3;
            }
            return 0;
        }
        public static int KindOfTheWork()
        {
            ConsoleKey selection;

            Console.Clear();
            Console.WriteLine("Kliknij liczbę, by wybrać rodzaj pracy jaki wykonujesz:\n");

            Console.WriteLine("1. Fizyczna");
            Console.WriteLine("2. Umysłowa\n");

            switch (selection = Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
            }
            return 0;
        }
        public static void UserInput()
        {
            bool result;

            for (int i = 0; i < 1; i++)
            {
                Console.Clear();
                Console.WriteLine("Podaj swój wiek:");
                result = int.TryParse(Console.ReadLine(), out _age);

                if (result && _age > 0 && _age<200)
                {

                }
                else
                {
                    Console.WriteLine("Wprowadź jeszcze raz poprawny wiek");
                    i--;
                    continue;

                }
                for (int j = 0; j < 1; j++)
                {
                    Console.Clear();
                    Console.WriteLine("Podaj swoją wagę:");

                    result = int.TryParse(Console.ReadLine(), out _weight);

                    if (result && _weight > 0 && _weight < 1000)
                    {
                    }
                    else
                    {
                        Console.WriteLine("Wprowadź jeszcze raz poprawną wagę");
                        j--;
                        continue;
                    }

                    for (int k = 0; k < 1; k++)
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj jeszcze raz poprawny wzrost");

                        result = int.TryParse(Console.ReadLine(), out _height);
                        if (result && _height > 0 && _height < 400)
                        {
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowa wartość");
                            k--;
                            continue;
                        }
                    }
                }
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
        static void TheUserCheckTheData()
        {
            Console.Clear();
            Console.WriteLine($"Sprawdź proszę swoje dane:\n\nPłeć: {genderSelection},\nWiek: {_age} lat,\nWaga: {_weight} kg,\nWzrost: {_height} cm,\nCel diety: {thePurposeOfTheDiet},\nRodzaj pracy: {kindOfTheWork},\nAktywność fizyczna: {howManyTimesYouTrain}.\n");
            Console.WriteLine("Jeśli podane są poprawne kliknij dowolny przycisk, by przejść dalej.\nJeśli podane dane są niepoprawne to możesz uruchomić program ponownie.");
            Console.ReadKey();
        }
    }
}