using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoje imię");
        string name = Console.ReadLine();
        Hello(name);
        Hello2("Witaj Arek");
        Console.ReadKey();
    }
    static void Hello(string name)
    {
        Console.WriteLine($"Witaj {name}!");
    }
    static void Hello2(string text)
    {
        Console.WriteLine(text);
    }
}