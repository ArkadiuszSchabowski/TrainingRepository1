using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrawidlowyKod
{
    internal class Operacja
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz dział nauki dla - .Net / C# develeoper, np. (10)");
                Console.WriteLine("");
                Console.WriteLine("1.Podstawy C#");
                Console.WriteLine("2.Visual Studio");
                Console.WriteLine("3.Programowanie obiektowe");
                Console.WriteLine("4.Podstawy SQL");
                Console.WriteLine("5.Bazy danych");
                Console.WriteLine("6.Wzorce architektoniczne aplikacji");
                Console.WriteLine("7.Wzorce projektowe");
                Console.WriteLine("8.Uniwersalne umiejętności programistyczne");
                Console.WriteLine("9.SOLID");
                Console.WriteLine("10.Dependency Injection");
                Console.WriteLine("11.Frameworks");
                Console.WriteLine("12.Logowanie zdarzeń w aplikacji");
                Console.WriteLine("13.Unit testy");
                Console.WriteLine("14.Inne rodzaje testów");
                Console.WriteLine("15.Oprócz kodu");
                Console.WriteLine("16.Cashing danych");
                Console.WriteLine("17.Microservices");
                Console.WriteLine("");

                String userInput = Console.ReadLine();
                int firstDecision = int.Parse(userInput);

                while (firstDecision == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("1.Podstawy C#");
                    Console.WriteLine("");
                    Console.WriteLine("1.Zmienne");
                    Console.WriteLine("2.Typy");
                    Console.WriteLine("3.Pętle");
                    Console.WriteLine("4.Instrukcje warunkowe");
                    Console.WriteLine("5.Obsługa błędów");
                    Console.WriteLine("6.Kolekcje danych");
                    Console.WriteLine("");

                    String userInpot = Console.ReadLine();
                    int secondDecision = int.Parse(userInpot);

                    while (secondDecision == 3)
                    {
                        Console.WriteLine("Podstawy C# -> Pętle");
                        Console.WriteLine();
                        Console.WriteLine("1.Pętla for");
                        Console.WriteLine("2.Pętla while");
                        Console.WriteLine("3.Pętla do while");
                        Console.ReadLine();
                    }
                }
                if (firstDecision == 2)
                {


                    Console.WriteLine("");
                    Console.WriteLine("2. Visual Studio");
                    Console.WriteLine("");
                    Console.WriteLine("2A. Tworzenie projektów");
                    Console.WriteLine("2B. Debuggowanie");
                    Console.WriteLine("2C. Resharper, skróty etc");
                    Console.WriteLine("2D. Publikowanie aplikacji");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                if (firstDecision == 3)
                {

                    Console.WriteLine("");
                    Console.WriteLine("3.Programowanie obiektowe");
                    Console.WriteLine("");
                    Console.WriteLine("1.Klasy, obiekty i interfejsy");
                    Console.WriteLine("2.Paradygmaty programowania");
                    Console.WriteLine("");

                    String userInpot = Console.ReadLine();
                    int secondDecision = int.Parse(userInpot);

                    while (secondDecision == 2)
                    {
                        Console.WriteLine("Programowanie obiektowe -> Paradygmaty Programowania");
                        Console.WriteLine();
                        Console.WriteLine("1.Abstrakcja");
                        Console.WriteLine("2.Hermetyzacja");
                        Console.WriteLine("3.Polimorfizm");
                        Console.WriteLine("4.Dziedziczenie");
                        Console.ReadLine();
                    }
                }

                    if (firstDecision == 4)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("4.Podstawy SQL");
                        Console.WriteLine("");
                        Console.WriteLine("4A.Projektowanie bazy danych");
                        Console.WriteLine("4B.Język SQL");
                        Console.WriteLine("4C.Normalizacja baz");
                        Console.WriteLine("4D.Podstawowa obsługa serwera bazodanowego");
                        Console.WriteLine("");
                        Console.ReadKey();


                    }
                    if (firstDecision == 5)
                    {


                        Console.WriteLine("");
                        Console.WriteLine("5.Bazy danych");
                        Console.WriteLine("");
                        Console.WriteLine("1.Relacyjne");
                        Console.WriteLine("2.Nierelacyjne");
                        Console.WriteLine("");

                        String userInpot = Console.ReadLine();
                        int secondDecision = int.Parse(userInpot);

                        while (secondDecision == 1)
                        {
                            Console.WriteLine("Bazy Danych -> Relacyjne");
                            Console.WriteLine();
                            Console.WriteLine("1.SQL Serwer");
                            Console.WriteLine("2.Postgre SQL");
                            Console.WriteLine("3.MySQL");
                            Console.ReadLine();

                        }
                    while (secondDecision == 2)
                    {
                        Console.WriteLine("Bazy Danych -> Nierelacyjne");
                        Console.WriteLine();
                        Console.WriteLine("1.MongoDB");
                        Console.WriteLine("2.DynamoDB");
                        Console.WriteLine("3.CosmosDB");
                        Console.ReadLine();

                    }
                    if (firstDecision == 6)
                    {


                        Console.WriteLine("");
                        Console.WriteLine("6.Wzorce architektoniczne aplikacji");
                        Console.WriteLine("");
                        Console.WriteLine("6A.Architektura wielowarstwowa");
                        Console.WriteLine("6B.Architektura trójwarstwowa");
                        Console.WriteLine("6C.MVC");
                        Console.WriteLine("6D.MVVM");
                        Console.WriteLine("6E.SOA");
                        Console.WriteLine("6F.CQRS");
                        Console.WriteLine();
                        Console.ReadKey();

                    }
                    if (firstDecision == 7)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("7.Wzorce projektowe");
                        Console.WriteLine("");
                        Console.WriteLine("7A.Kreacyjne");
                        Console.WriteLine("7B.Strukturalne");
                        Console.WriteLine("7C.Behawioralne");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 8)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("8.Uniwersalne umiejętności programistyczne");
                        Console.WriteLine("");
                        Console.WriteLine("8A.System kontroli wersji");
                        Console.WriteLine("8B.HTTP/REST");
                        Console.WriteLine("8C.Algorytmy i struktury danych");
                        Console.WriteLine("8D.DDD");
                        Console.WriteLine("8E.Zasady wielowątkowości");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 9)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("9.Solid");
                        Console.WriteLine("");
                        Console.WriteLine("9A.Single responsibility principle");
                        Console.WriteLine("9B. Open/closed principle");
                        Console.WriteLine("9C. Liskov substition principle");
                        Console.WriteLine("9D. Interface segregation principle");
                        Console.WriteLine("9E. Dependency inversion principle");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 10)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("10.Dependency Injection");
                        Console.WriteLine("");
                        Console.WriteLine("10A.Zasady DI");
                        Console.WriteLine("10B.Cykle życia w DI");
                        Console.WriteLine("10C.Frameworks");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 11)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("11.Frameworks");
                        Console.WriteLine("");
                        Console.WriteLine("11A.Entity framework");
                        Console.WriteLine("11B.AutoMapper");
                        Console.WriteLine("11C.Fluent Validation");
                        Console.WriteLine("11D.Swagger");
                        Console.WriteLine("11E.Polly");
                        Console.WriteLine("11F.MediaTr");
                        Console.WriteLine("11G.Hangfire");
                        Console.WriteLine("11H.FluentScheduler");
                        Console.WriteLine("11I.Express Mapper");
                        Console.WriteLine("11J.Noda Time");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 12)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("12.Logowanie zdarzeń w aplikacji");
                        Console.WriteLine("");
                        Console.WriteLine("12A.NLog");
                        Console.WriteLine("12B.SeriLog");
                        Console.WriteLine("12C.Log4net");
                        Console.WriteLine("12D.Elmah");
                        Console.WriteLine("12E.ApplicationInsight");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 13)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("13.Unit testy");
                        Console.WriteLine("");
                        Console.WriteLine("13A.Arrange / Act / Assert");
                        Console.WriteLine("13B.Frameworks");
                        Console.WriteLine("13C.Mocking");
                        Console.WriteLine("13D.TDD");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 14)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("14.Inne rodzaje testów");
                        Console.WriteLine("");
                        Console.WriteLine("14A.Integracyjne");
                        Console.WriteLine("14B.Behawioralne");
                        Console.WriteLine("14C.E2E");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 15)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("15.Oprócz kodu");
                        Console.WriteLine("");
                        Console.WriteLine("15A.Organizacja pracy");
                        Console.WriteLine("15B.Narzędzia do zarządzania zadaniami");
                        Console.WriteLine("15C.Dokumentacja");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 16)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("16.Cashing danych");
                        Console.WriteLine("");
                        Console.WriteLine("16A.In Memory Cache");
                        Console.WriteLine("16B.Rozproszony Cache");
                        Console.WriteLine("");
                        Console.ReadKey();

                    }
                    if (firstDecision == 17)
                    {

                        Console.WriteLine("");
                        Console.WriteLine("17.Mikroservices");
                        Console.WriteLine("");
                        Console.WriteLine("17A.Architektury i komunikacja w mikroserwisach");
                        Console.WriteLine("17B.PubSub pattern");
                        Console.WriteLine("17C.Message Brokers");
                        Console.WriteLine("17D.IoT");
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}