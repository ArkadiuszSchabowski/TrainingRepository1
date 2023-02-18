using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace testOSwinkach
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Name, phoneFriend;
            string questionOne, questionTwo, questionThree, questionFour;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Witamy w Milionerach świnko!\n");

                Console.Write("Podaj swoje imię: ");

                Name = InputName();

                Introduction();

                PriceBeforeAnswerOne();

                QuestionOne();

                questionOne = Console.ReadLine();

                switch (questionOne)
                {
                    case "F":
                        PhoneFriend();
                        break;
                    case "R":
                        Console.WriteLine($"Mimo wszystko dziękujemy za udział w programie {Name}!");
                        Console.WriteLine("Chcesz zagrać jeszcze raz? - naciśnij dowolny klawisz");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "P":
                        Console.WriteLine($"Drogie Świnki pomóżcie proszę {Name} podjąć poprawną decyzję");
                        break;
                    case "H":
                        Console.WriteLine("Prosimy o losowe odrzucenie dwóch błędnych odpowiedzi");
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Green;
                        CorrectAnswerOne();
                        PriceAfterCorrectAnswerOne();
                        QuestionTwo();
                        break;
                    default:
                        IncorrectAnswerOne();
                        break;
                }
                questionTwo = Console.ReadLine();
                switch (questionTwo)
                {
                    case "D":
                        CorrectAnswerTwo();
                        PriceAfterCorrectAnswerTwo();
                        QuestionThree();
                        break;
                    default:
                        IncorrectAnswerTwo();
                        break;
                }
                questionThree = Console.ReadLine();

                switch (questionThree)
                {
                    case "R":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Dziękujemy za grę {Name}. Zapas dobrej jakości karmy: Versele Laga jest Twój!");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby zagrać jeszcze raz");
                        Console.ReadKey();
                        break;
                    case "C":
                        CorrectAnswerThree();
                        PriceAfterCorrectAnswerThree();
                        QuestionFour();
                        break;
                    default:
                        IncorrectAnswerThree();
                        break;
                }
                questionFour = Console.ReadLine();

                switch (questionFour)
                {
                    case "D":
                        CorrectAnswerFour();
                        break;
                    case "P":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Skorzystajmy z pomocy naszej świńskiej publicznośći");
                        break;
                    case "H":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Prosimy o losowe odrzucenie dwóch błędnych odpowiedzi");
                        break;
                    case "R":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Dziękujemy za grę {Name}. Catering warzywnyny od firmy Chrumka na cały kolejny miesiąc. Gratulacje!");
                        Console.WriteLine("Naciśnij dowolny klawisz, aby zagrać jeszcze raz");
                        Console.ReadKey();
                        break;
                    case "F":
                        PhoneFriend();
                        break;
                    default:
                        IncorrectAnswerFour();
                        break;
                }
                phoneFriend = Console.ReadLine();

                if (phoneFriend == "K")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Dzwonimy do świnki Kropki\n");
                    Console.WriteLine("Dryń, dryń, dryń\n");
                    Console.WriteLine("Dryń, dryń, dryń\n");
                    Console.WriteLine($"Halo {Name} tu Kropka. Wydaje mi się, że odpowiedź D jest prawidłowa.");
                    Console.WriteLine("Myślę, że możesz zaryzykować.");
                    Console.ReadKey();
                }
                if (phoneFriend == "T")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nDzwonimy do świnki Toli\n");
                    Console.WriteLine("Dryń, dryń, dryń\n");
                    Console.WriteLine("Dryń, dryń, dryń\n");
                    Console.WriteLine($"Hej {Name} tu Tola. Na pewno chodzi o klatkę sporych rozmiarów");
                    Console.WriteLine("Waham się między odpowiedziami C i D.");
                    Console.WriteLine("Może skorzystaj jeszcze z jednego koła ratunkowego");
                    Console.ReadKey();
                }
            }
        }
        private static void Introduction()
        {
            Console.WriteLine("\nTest o świnkach morskich.\n");
            Console.Write("Czy jesteś gotów zagrać o atrakcyjne nagrody? Jeśli tak naciśnij dowolny klawisz. ");
            Console.ReadKey();
            Console.Clear();
        }
        private static string InputName()
        {
            return Console.ReadLine();
        }
        private static void PriceBeforeAnswerOne()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Twoja aktualna nagroda:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
            Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
            Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
            Console.WriteLine("Zestaw świnkowych domków");
            Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
            Console.WriteLine("Świński Hamak (nagroda gwarantowana)");
            Console.WriteLine("Miesięczny warzywny catering dietetyczny");
            Console.WriteLine("Miesięczny zapas karmy Versele Laga");
            Console.WriteLine("Zapas siana na miesiąc (nagroda gwarantowana)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Świński Kubek (nagroda pocieszenia)\n\n");
        }
        private static void QuestionOne()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pytanie 1. Na czym najbardziej zetrze zęby świnka morska?\n");
            Console.WriteLine("A - jedząc ogórek");
            Console.WriteLine("B - delektując się sianem");
            Console.WriteLine("C - pijąc z poidełka");
            Console.WriteLine("D - jedząc trawę\n");

            Console.WriteLine("R - chcę zrezygnować już w tym momencie");
            Console.WriteLine("F - skorzystajmy z pomocy jednego z moich świnskich przyjaciół\n");
        }

        private static void CorrectAnswerOne()
        {
            Console.WriteLine("\nGratulacje to poprawna odpowiedź! Zapas siana na miesiąc jest Twój!");
            Console.WriteLine("Przypominam również, że to suma gwarantowana!\n");
            Console.WriteLine("Gramy dalej? - jeśli tak naciśnij dowolny klawisz");
            Console.ReadKey();
            Console.Clear();
        }
        private static void IncorrectAnswerOne()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNiestety odpowiedź pierwszego pytania jest niepoprawna.");
            Console.WriteLine("Ale nie martw się otrzymujesz nagrodę pocieszenia - świński kubek.\n");
            Console.Write("Zagraj jeszcze raz - naciśnij dowolny klawisz: ");
            Console.ReadKey();
            Console.Clear();
        }
        private static void PriceAfterCorrectAnswerOne()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Twoja aktualna nagroda:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
            Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
            Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
            Console.WriteLine("Zestaw świnkowych domków");
            Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
            Console.WriteLine("Świński Hamak (nagroda gwarantowana)");
            Console.WriteLine("Miesięczny warzywny catering dietetyczny");
            Console.WriteLine("Miesięczny zapas karmy Versele Laga");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zapas siana na miesiąc (nagroda gwarantowana)");
            Console.WriteLine("Świński Kubek - (nagroda pocieszenia)\n\n");
        }
        private static void QuestionTwo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pytanie 2. Jak Inaczej kiedyś nazywano świnkę morską?\n");
            Console.WriteLine("A - świnką miniaturową");
            Console.WriteLine("B - powiększonym chomikiem");
            Console.WriteLine("C - uszatniczką");
            Console.WriteLine("D - świnką nadmorską\n");
        }
        private static void CorrectAnswerTwo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nGratulacje otrzymujesz gwarantowany miesięczny zapas dobrej jakości karmy: Versele Laga!\n");
            Console.WriteLine("Naciśnij dowolny klawisz, by kontynuować\n");
            Console.ReadKey();
            Console.Clear();
        }
        private static void IncorrectAnswerTwo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nNiestety odpowiedź drugiego pytania jest błędna. Dziękujemy za grę świnko.");
            Console.WriteLine("Otrzymujesz nagrodę pocieszenia - świński kubek!\n");
            Console.WriteLine($"Czy chcesz zagrać jeszcze raz?");
            Console.Write("Jeśli tak wciśnij dowolny klawisz ");
            Console.ReadKey();
            Console.Clear();
        }
        private static void PriceAfterCorrectAnswerTwo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Twoja aktualna nagroda:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
            Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
            Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
            Console.WriteLine("Zestaw świnkowych domków");
            Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
            Console.WriteLine("Świński Hamak (nagroda gwarantowana");
            Console.WriteLine("Miesięczny warzywny catering dietetyczny");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Miesięczny zapas karmy Versele Laga");
            Console.WriteLine("Zapas siana na miesiąc (nagroda gwarantowana)");
            Console.WriteLine("Świński Kubek (nagroda pocieszenia)\n\n");
        }
        private static void QuestionThree()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pytanie Nr 3. Jak inaczej inaczej nazwiemy świnkę o rasie Rozetka?");
            Console.WriteLine("A - Sheltie");
            Console.WriteLine("B - Dlugowłosą");
            Console.WriteLine("C - Abisyńską");
            Console.WriteLine("D - Krótkowłosą\n");
        }
        private static void CorrectAnswerThree()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo to poprawna odpowiedź. Świnka rozetka to inaczej świnka abisyńska.");
            Console.WriteLine("Miesięczny warzywny catering dietetyczny od firmy Chrumka jest Twój!\n");
            Console.WriteLine("Gotowy grać dalej? - Jeśli tak, naciśnij dowolny klawisz");
            Console.ReadKey();
            Console.Clear();
        }
        private static void IncorrectAnswerThree()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Poprawna odpowiedź to C-Abisyńską. Dziękujemy za grę.");
            Console.Write("Zapas siana na cały kolejny miesiąc jest Twój!");
        }
        private static void PriceAfterCorrectAnswerThree()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Twoja aktualna nagroda:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
            Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
            Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
            Console.WriteLine("Zestaw świnkowych domków");
            Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
            Console.WriteLine("Świński Hamak (nagroda gwarantowana)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Miesięczny warzywny catering dietetyczny");
            Console.WriteLine("Miesięczny zapas karmy Versele Laga");
            Console.WriteLine("Zapas siana na miesiąc (nagroda gwarantowana)");
            Console.WriteLine("Świński Kubek (nagroda pocieszenia)\n\n");
        }
        private static void QuestionFour()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pytanie Nr 4.Jaki powinien być najmniejszy rozmiar klatki przeznaczonej dla 2 świnek?");
            Console.WriteLine("A - 40cmx40cm");
            Console.WriteLine("B - 60cmx40cm");
            Console.WriteLine("C - 80cmx60cm");
            Console.WriteLine("D - 100cmx60cm\n");

            Console.WriteLine("P - chcę poprosić o pomoc świńską publiczność");
            Console.WriteLine("H - skorzystam z koła ratunkowego 50/50");
            Console.WriteLine("F - Zadzwońmy do jednego z moich przyjaciół\n");

            Console.WriteLine("R - Chcę zrezygnować i wziąć miesięczny warzywny catering dietetyczny\n");
        }
        private static void CorrectAnswerFour()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBrawo to czwarta poprawna odpowiedź! Świński hamak jest Twój!");
            Console.WriteLine($"Pamiętaj, że nawet jeśli odpowiesz błędnie na któreś z kolejnych pytań, będziesz mógł wylegiwać się wygodnie o każdej porze!");
            Console.ReadKey();
            Console.Clear();
        }
        private static void IncorrectAnswerFour()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Niestety to niepoprawna odpowiedź. Nie martw się otrzymujesz nagrodę gwarantowaną - zapas siana na cały kolejny miesiąc! Gratulacje!");
            Console.ReadKey();
            Console.Clear();
        }
        private static void PhoneFriend()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Zadzwońmy więc do przyjaciela");
            Console.WriteLine("Kto mógłby znać odpowiedź na to pytanie? Świnka Kropka czy Świnka Tola?");
        }
    }
}