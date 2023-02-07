using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOSwinkach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, phoneFriend;
            string questionOne, questionTwo, questionThree, questionFour;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Witamy w Milionerach świnko!\n");

            Console.Write("Podaj swoje imię: ");
            Name = Console.ReadLine();

                Console.WriteLine("\nTest o świnkach morskich.\n");
                Console.Write("Czy jesteś gotów zagrać o atrakcyjne nagrody? Jeśli tak naciśnij dowolny klawisz. ");
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Twoja aktualna nagroda:\n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
                Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
                Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
                Console.WriteLine("Zestaw świnkowych domków");
                Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
                Console.WriteLine("Świński Hamak");
                Console.WriteLine("Miesięczny warzywny catering dietetyczny");
                Console.WriteLine("Miesięczny zapas karmy Versele Laga");
                Console.WriteLine("Zapas siana na miesiąc (Suma gwarantowana)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Świński Kubek - nagroda pocieszenia\n\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pytanie 1. Na czym najbardziej zetrze zęby świnka morska?\n");
                Console.WriteLine("A - jedząc ogórek");
                Console.WriteLine("B - delektując się sianem");
                Console.WriteLine("C - pijąc z poidełka");
                Console.WriteLine("D - jedząc trawę\n");

                questionOne = Console.ReadLine();

                switch (questionOne)
                {
                    case "B":
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nGratulacje to poprawna odpowiedź! Zapas siana na miesiąc jest Twój!");
                            Console.WriteLine("Przypominam również, że to suma gwarantowana!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Gramy dalej? - jeśli tak naciśnij dowolny klawisz");
                            Console.ReadKey();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Twoja aktualna nagroda:\n");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
                            Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
                            Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
                            Console.WriteLine("Zestaw świnkowych domków");
                            Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
                            Console.WriteLine("Świński Hamak");
                            Console.WriteLine("Miesięczny warzywny catering dietetyczny");
                            Console.WriteLine("Miesięczny zapas karmy Versele Laga");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Zapas siana na miesiąc (Suma gwarantowana)");
                            Console.WriteLine("Świński Kubek - nagroda pocieszenia\n\n");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pytanie 2. Jak Inaczej kiedyś nazywano świnkę morską?\n");
                            Console.WriteLine("A - świnką miniaturową");
                            Console.WriteLine("B - powiększonym chomikiem");
                            Console.WriteLine("C - uszatniczką");
                            Console.WriteLine("D - świnką nadmorską\n");

                            questionTwo = Console.ReadLine();

                            switch (questionTwo)
                            {
                                case "D":
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"\nGratulacje {Name} otrzymujesz gwarantowany 1000zł!");
                                        Console.WriteLine("Idziesz jak burza! - Naciśnij dowolny klawisz, by kontynuować\n");
                                        Console.ReadKey();
                                        Console.Clear();

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Twoja aktualna nagroda:\n");

                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
                                        Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
                                        Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
                                        Console.WriteLine("Zestaw świnkowych domków");
                                        Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
                                        Console.WriteLine("Świński Hamak");
                                        Console.WriteLine("Miesięczny warzywny catering dietetyczny");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Miesięczny zapas karmy Versele Laga");
                                        Console.WriteLine("Zapas siana na miesiąc (Suma gwarantowana)");
                                        Console.WriteLine("Świński Kubek - nagroda pocieszenia\n\n");

                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Pytanie Nr 3.Jak inaczej inaczej nazwiemy świnkę o rasie Rozetka?");
                                        Console.WriteLine("A - Sheltie");
                                        Console.WriteLine("B - Dlugowłosą");
                                        Console.WriteLine("C - Abisyńską");
                                        Console.WriteLine("D - Krótkowłosą\n");

                                        questionThree = Console.ReadLine();

                                        switch (questionThree)
                                        {
                                            case "R":
                                                {
                                                    Console.WriteLine($"Dziękujemy za grę {Name}. Wygrałeś 2000zł!");
                                                    Console.WriteLine("Naciśnij dowolny klawisz, aby zagrać jeszcze raz");
                                                    Console.ReadKey();

                                                }
                                                break;

                                            case "C":
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Brawo to poprawna odpowiedź. Wygrywasz 2000zł! Świnka rozetka to inaczej świnka abisyńska\n");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("Gotowy grać dalej? - Jeśli tak, naciśnij dowolny klawisz");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Twoja aktualna nagroda:\n");

                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Ogromny zagrodzony świński wybieg dla całego stada zakryty antydrapieżną siatką");
                                                    Console.WriteLine("2-tygodniowe wakacje all-inclusive na rajską wyspę Pig Beach na Bahamach z osobą towarzyszącą");
                                                    Console.WriteLine("Zestaw 10 zabiegów SPA oraz kąpieli błotnych");
                                                    Console.WriteLine("Zestaw świnkowych domków");
                                                    Console.WriteLine("Klatka dla 3 świnek o wymiarach 120cmx60cm");
                                                    Console.WriteLine("Świński Hamak");
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Miesięczny warzywny catering dietetyczny");
                                                    Console.WriteLine("Miesięczny zapas karmy Versele Laga");
                                                    Console.WriteLine("Zapas siana na miesiąc (Suma gwarantowana)");
                                                    Console.WriteLine("Świński Kubek - nagroda pocieszenia\n\n");

                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("Pytanie Nr 4.Jaki powinien być najmniejszy rozmiar klatki przeznaczonej dla 2 świnek?");
                                                    Console.WriteLine("A - 40cmx40cm");
                                                    Console.WriteLine("B - 60cmx40cm");
                                                    Console.WriteLine("C - 80cmx60cm");
                                                    Console.WriteLine("D - 100cmx60cm\n");

                                                    Console.WriteLine("P - chcę poprosić o pomoc świńską publiczność");
                                                    Console.WriteLine("H - skorzystam z koła ratunkowego 50/50");
                                                    Console.WriteLine("F - Zadzwońmy do jednego z moich przyjaciół\n");

                                                    Console.WriteLine("R - Chcę zrezygnować i wziąć 2000zł\n");


                                                    questionFour = Console.ReadLine();
                                                    {


                                                        switch (questionFour)
                                                        {
                                                            case "D":
                                                                {
                                                                    Console.WriteLine("Brawo to czwarta poprawna odpowiedź! Wygrywasz 4000zł.");
                                                                    Console.ReadKey();
                                                                    break;
                                                                }
                                                            case "R":
                                                                {
                                                                    Console.WriteLine($"Dziękujemy za grę {Name}. Wygrałeś 2000zł!");
                                                                    Console.WriteLine("Naciśnij dowolny klawisz, aby zagrać jeszcze raz");
                                                                    Console.ReadKey();
                                                                    break;
                                                                }
                                                            case "P":
                                                                { 
                                                                    Console.WriteLine ("Skorzystajmy z pomocy naszej świńskiej publicznośći");
                                                                }
                                                                break;
                                                            case "H":
                                                                {
                                                                    Console.WriteLine("Prosimy o losowe odrzucenie dwóch błędnych odpowiedzi");
                                                                }
                                                                break;
                                                            case "F":
                                                                {
                                                                    Console.WriteLine("Zadzwońmy więc do przyjaciela");
                                                                    Console.WriteLine("Kto mógłby znać odpowiedź na to pytanie? Świnka Kropka czy Świnka Tola?");
                                                                    phoneFriend = Console.ReadLine();
                                                                    if (phoneFriend == "K")
                                                                    {
                                                                        Console.WriteLine("Dzwonimy do świnki Kropki\n");
                                                                        Console.WriteLine("Dryń, dryń, dryń\n");
                                                                        Console.WriteLine("Dryń, dryń, dryń\n");
                                                                        Console.WriteLine($"Halo {Name} tu Kropka. Postaram się Ci pomóc.");
                                                                        Console.ReadKey();
                                                                    }
                                                                    if (phoneFriend == "T")
                                                                    {
                                                                        Console.WriteLine("Dzwonimy do świnki Toli");
                                                                        Console.WriteLine("Dryń, dryń, dryń\n");
                                                                        Console.WriteLine("Dryń, dryń, dryń\n");
                                                                        Console.WriteLine($"Hej {Name} tu Tola. Mam nadzieję, że będę znała odpowiedź na to pytanie");
                                                                        Console.ReadKey();
                                                                    }

                                                                }
                                                                break;
                                                            default:
                                                                {
                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                    Console.WriteLine($"Niestety to niepoprawna odpowiedź.{Name} otrzymujesz gwarantowany 1000zł! Gratulacje!");
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                        }
                                                    }
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Poprawna odpowiedź to C-Abisyńską. Dziękujemy za grę. Wygrywasz gwarantowany 1000zł");
                                                }

                                                break;
                                        }
                                        break;
                                    }
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\nNiestety odpowiedź drugiego pytania jest błędna. Dziękujemy za grę {Name}.");
                                    Console.WriteLine("Otrzymujesz nagrodę pocieszenia - świński kubek.\n");
                                    Console.WriteLine($"Czy chcesz zagrać jeszcze raz {Name}?");
                                    Console.Write("Jeśli tak wciśnij dowolny klawisz ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                            break;
                        }
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nŚwinko {Name}, niestety odpowiedź pierwszego pytania jest niepoprawna.");
                        Console.WriteLine("Ale nie martw się otrzymujesz nagrodę pocieszenia - świński kubek.\n");
                        Console.Write("Zagraj jeszcze raz - naciśnij dowolny klawisz: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}