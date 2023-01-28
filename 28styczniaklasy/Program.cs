using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28styczniaklasy
{
    class Osoba
    {
        int _wiek;

        public int PobierzWiek()
        {
            return _wiek;
        }

        public void UstawWiek(int wiek)
        {
            _wiek = wiek;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba Karol = new Osoba();

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
            Console.WriteLine("9.Solid");
            Console.WriteLine("10.Dependency Injection");
            Console.WriteLine("11.Frameworks");
            Console.WriteLine("12.Logowanie zdarzeń w aplikacji");
            Console.WriteLine("13.Unit testy");
            Console.WriteLine("14.Inne rodzaje testów");
            Console.WriteLine("15.Oprócz kodu");
            Console.WriteLine("16.Cashing danych");
            Console.WriteLine("17.Microservices");
            Console.WriteLine("");
            Karol.UstawWiek(Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine(Karol.PobierzWiek());

            System.Console.ReadKey();
        }
    }
}