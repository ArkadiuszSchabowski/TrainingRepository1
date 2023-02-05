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
            string Name;
            string questionOne, questionTwo, questionThree;

            Console.WriteLine("Witamy w Milionerach świnko!\n");

            Console.Write("Podaj swoje imię: ");
            Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("\nTest o świnkach morskich. Grasz o 500 złotych!\n");

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
                            Console.WriteLine("\nGratulacje to poprawna odpowiedź! Wygrałeś 500zł! Zagrajmy o 1000zł!\n");

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
                                        Console.WriteLine($"\nGratulacje {Name} otrzymujesz gwarantowany 1000zł!");
                                        Console.WriteLine("Idziesz jak burza!\n");

                                        Console.WriteLine("Pytanie Nr 3.Jak inaczej inaczej nazwiemy świnkę o rasie Rozetka?");
                                        Console.WriteLine("A - Sheltie");
                                        Console.WriteLine("B - Dlugowłosą");
                                        Console.WriteLine("C - Abisyńską");
                                        Console.WriteLine("D - Krótkowłosą\n");

                                        questionThree = Console.ReadLine();

                                        switch (questionThree)
                                        {
                                            case "C":
                                                {
                                                    Console.WriteLine("Brawo to poprawna odpowiedź. Wygrywasz 2000zł! Świnka rozetka to inaczej świnka abisyńska");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine($"Niestety to niepoprawna odpowiedź.{Name} otrzymujesz gwarantowany 1000zł! Gratulacje!");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine($"\nNiestety odpowiedź drugiego pytania jest błędna. Dziękujemy za grę {Name}.");
                                        Console.WriteLine("Otrzymujesz nagrodę pocieszenia - świński kubek.\n");
                                        Console.WriteLine($"Czy chcesz zagrać jeszcze raz {Name}?");
                                        Console.Write("Jeśli tak wciśnij dowolny klawisz ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }

                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"\nŚwinko {Name}, niestety odpowiedź pierwszego pytania jest niepoprawna.");
                            Console.WriteLine("Ale nie martw się otrzymujesz nagrodę pocieszenia - świński kubek.\n");
                            Console.Write("Zagraj jeszcze raz - naciśnij dowolny klawisz: ");
                            Console.ReadKey();
                            Console.Clear();
                            {
                                break;
                            }
                        }
                }
            }
        }
    }
}