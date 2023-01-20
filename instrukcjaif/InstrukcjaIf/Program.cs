using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int zmienna1, zmienna2;

        Console.WriteLine("Wprowadź 1 cyfrę");
        zmienna1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wprowadź 2 cyfrę");
        zmienna2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wynik działania to " + (zmienna1 + zmienna2));

        double pierwsza, druga;

        Console.WriteLine("Wprowadź 3 cyfrę");
        pierwsza = double.Parse(Console.ReadLine());
        Console.WriteLine("Wprowadź 4 cyfrę");
        druga = double.Parse(Console.ReadLine());
     

        if (true)
        }
    Console.WriteLine("wynik to: " + (zmienna1 + zmienna2 + pierwsza + druga));
    }
}