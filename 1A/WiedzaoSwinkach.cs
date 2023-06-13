using System;

internal class Program
{

    static void Main(string[] args)
    {
        bool prawda;
        bool nieprawda;
        double A;
        double B;
        double C;
        double D;

        Console.WriteLine("Quiz na znajomość świnek morskich");
        Console.WriteLine("Pytanie nr.1. Na czym może ścierać zęby świnka morska");
        Console.WriteLine("A-Banan");
        Console.WriteLine("B-Ogórek");
        Console.WriteLine("C-Siano");
        Console.WriteLine("D-Jabłko");
        prawda = double.TryParse(Console.ReadLine(), out C);

        if (C)
        
            Console.WriteLine("Brawo.Świnka może zetrzeć zęby na sianie");
        }
        else (Console = 0)
        {
            Console.WriteLine("Twoja wiedza na temat świnek morskich wymaga powtórki");
        }

    }
}