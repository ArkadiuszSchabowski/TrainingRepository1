using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoje imię");
        string name = Console.ReadLine();
        Hello(name);
        Console.ReadKey();
    }
    static void Hello(string name)
    {
        Console.WriteLine($"Witaj {name}!");
    }
}