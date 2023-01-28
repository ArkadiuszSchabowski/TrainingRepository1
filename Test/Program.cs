using System;
using System.Collections.Generic;

class Menu
{
    public string Lista { get; set; }
    public List<Menu> Submenus { get; set; }
    public string Lista1 { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Menu Glowne = new Menu();

        Glowne.Lista = "Wybierz liczbę, przykładowo: (1)";
        Console.WriteLine("Wybierz dział nauki dla - .Net / C# develeoper");
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

        System.Console.WriteLine(Glowne.Lista);

        Glowne.Lista1 = "Wybierz liczbę, przykładowo: (2)";

        Console.WriteLine("");
        Console.WriteLine("1.Podstawy C#");
        Console.WriteLine("");
        Console.WriteLine("1A.Zmienne");
        Console.WriteLine("1B.Typy");
        Console.WriteLine("1C.Pętle");
        Console.WriteLine("1D.Instrukcje warunkowe");
        Console.WriteLine("1E.Obsługa błędów");
        Console.WriteLine("1F.Kolekcje danych");
        Console.WriteLine("");
        Console.ReadLine(); ;
        System.Console.WriteLine(Glowne.Lista1);

        System.Console.ReadKey();
    }
}