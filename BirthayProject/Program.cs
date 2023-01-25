using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrawidlowyKod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                while (true)
                {
                    Console.WriteLine("Jaką chcesz kawę?");
                    Console.WriteLine("1. Czarną");
                    Console.WriteLine("2. Biała");
                    Console.WriteLine("3.Koniec");

                    ConsoleKeyInfo klawisz = Console.ReadKey();
                    switch (klawisz.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.WriteLine("1.Bez cukru");
                            Console.WriteLine("2.Dodaj cukier");
                            Console.ReadLine();
                            break;

                        case ConsoleKey.D2:
                            Console.Clear(); break
                                ;
                        case ConsoleKey.Escape: break;

                        case ConsoleKey.D3:

                            Environment.Exit(0); break;

                        default: break;
                    }
                }
            }
        }
    }
}

//string operationMenu, operation1;

//            Console.WriteLine("Wybierz dział nauki dla - .Net / C# develeoper, np. (10)");
//            Console.WriteLine("");
//            Console.WriteLine("1.Podstawy C#");
//            Console.WriteLine("2.Visual Studio");
//            Console.WriteLine("3.Programowanie obiektowe");
//            Console.WriteLine("4.Podstawy SQL");
//            Console.WriteLine("5.Bazy danych");
//            Console.WriteLine("6.Wzorce architektoniczne aplikacji");
//            Console.WriteLine("7.Wzorce projektowe");
//            Console.WriteLine("8.Uniwersalne umiejętności programistyczne");
//            Console.WriteLine("9.Solid");
//            Console.WriteLine("10.Dependency Injection");
//            Console.WriteLine("11.Frameworks");
//            Console.WriteLine("12.Logowanie zdarzeń w aplikacji");
//            Console.WriteLine("13.Unit testy");
//            Console.WriteLine("14.Inne rodzaje testów");
//            Console.WriteLine("15.Oprócz kodu");
//            Console.WriteLine("16.Cashing danych");
//            Console.WriteLine("17.Microservices");
//            Console.WriteLine("");

//            operationMenu = Console.ReadLine();

//            switch (operationMenu)
//            {
//                case "1":
//                    Console.WriteLine("");
//                    Console.WriteLine("1.Podstawy C#");
//                    Console.WriteLine("");
//                    Console.WriteLine("1A.Zmienne");
//                    Console.WriteLine("1B.Typy");
//                    Console.WriteLine("1C.Pętle");
//                    Console.WriteLine("1D.Instrukcje warunkowe");
//                    Console.WriteLine("1E.Obsługa błędów");
//                    Console.WriteLine("1F.Kolekcje danych");
//                    Console.WriteLine("");
//                    operation1 = Console.ReadLine();

//                        switch (operation1)
//                        {
//                            case "1C":
//                        }
//                        {
//                            break;
//                        }
//                    }
//            }
//        }
//    }


    //                    operation1 = Console.ReadLine();
    //                    switch (operation1)
    //                    {
    //                        case "1C":
    //                            Console.WriteLine();
    //                            Console.WriteLine("1C - Podstawy C# -> pętle(rodzaje pętli");
    //                            Console.WriteLine();
    //                            Console.WriteLine("1AC. pętla - for");
    //                            Console.WriteLine("1BC. pętla - while");
    //                            Console.WriteLine("1CC. pętla - do while");
    //                            Console.ReadKey();
    //                        {
    //                            break;
    //                                }
    //                    }
    //            }
    //        }
    //    }
    //}

//                case "2":
//                    Console.WriteLine("");
//                    Console.WriteLine("2. Visual Studio");
//                    Console.WriteLine("");
//                    Console.WriteLine("2A. Tworzenie projektów");
//                    Console.WriteLine("2B. Debuggowanie");
//                    Console.WriteLine("2C. Resharper, skróty etc");
//                    Console.WriteLine("2D. Publikowanie aplikacji");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "3":
//                    Console.WriteLine("");
//                    Console.WriteLine("3.Programowanie obiektowe");
//                    Console.WriteLine("");
//                    Console.WriteLine("3A.Klasy, obiekty i interfejsy");
//                    Console.WriteLine("3B.Paradygmaty programowania");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "4":
//                    Console.WriteLine("");
//                    Console.WriteLine("4.Podstawy SQL");
//                    Console.WriteLine("");
//                    Console.WriteLine("4A.Projektowanie bazy danych");
//                    Console.WriteLine("4B.Język SQL");
//                    Console.WriteLine("4C.Normalizacja baz");
//                    Console.WriteLine("4D.Podstawowa obsługa serwera bazodanowego");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "5":
//                    Console.WriteLine("");
//                    Console.WriteLine("5.Bazy danych");
//                    Console.WriteLine("");
//                    Console.WriteLine("5A.Relacyjne");
//                    Console.WriteLine("5B.Nierelacyjne");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "6":
//                    Console.WriteLine("");
//                    Console.WriteLine("6.Wzorce architektoniczne aplikacji");
//                    Console.WriteLine("");
//                    Console.WriteLine("6A.Architektura wielowarstwowa");
//                    Console.WriteLine("6B.Architektura trójwarstwowa");
//                    Console.WriteLine("6C.MVC");
//                    Console.WriteLine("6D.MVVM");
//                    Console.WriteLine("6E.SOA");
//                    Console.WriteLine("6F.CQRS");
//                    Console.WriteLine();
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "7":
//                    Console.WriteLine("");
//                    Console.WriteLine("7.Wzorce projektowe");
//                    Console.WriteLine("");
//                    Console.WriteLine("7A.Kreacyjne");
//                    Console.WriteLine("7B.Strukturalne");
//                    Console.WriteLine("7C.Behawioralne");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "8":
//                    Console.WriteLine("");
//                    Console.WriteLine("8.Uniwersalne umiejętności programistyczne");
//                    Console.WriteLine("");
//                    Console.WriteLine("8A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "9":
//                    Console.WriteLine("");
//                    Console.WriteLine("9.Solid");
//                    Console.WriteLine("");
//                    Console.WriteLine("9A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "10":
//                    Console.WriteLine("");
//                    Console.WriteLine("10.Dependency Injection");
//                    Console.WriteLine("");
//                    Console.WriteLine("10A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "11":
//                    Console.WriteLine("");
//                    Console.WriteLine("11.Frameworks");
//                    Console.WriteLine("");
//                    Console.WriteLine("11A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "12":
//                    Console.WriteLine("");
//                    Console.WriteLine("12.Logowanie zdarzeń w aplikacji");
//                    Console.WriteLine("");
//                    Console.WriteLine("12A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "13":
//                    Console.WriteLine("");
//                    Console.WriteLine("13.Unit testy");
//                    Console.WriteLine("");
//                    Console.WriteLine("13A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "14":
//                    Console.WriteLine("");
//                    Console.WriteLine("14.Inne rodzaje testów");
//                    Console.WriteLine("");
//                    Console.WriteLine("14A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "15":
//                    Console.WriteLine("");
//                    Console.WriteLine("15.Oprócz kodu");
//                    Console.WriteLine("");
//                    Console.WriteLine("15A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "16":
//                    Console.WriteLine("");
//                    Console.WriteLine("16.Cashing danych");
//                    Console.WriteLine("");
//                    Console.WriteLine("16A.");
//                    Console.WriteLine("16B.");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                case "17":
//                    Console.WriteLine("");
//                    Console.WriteLine("17.Mikroservices");
//                    Console.WriteLine("");
//                    Console.WriteLine("17A.");
//                    Console.WriteLine("");
//                    Console.ReadLine();
//                    {
//                        break;
//                    }
//                default:
//                    {
//                        break;
//                    }
//            }
//        }
//    }
//}