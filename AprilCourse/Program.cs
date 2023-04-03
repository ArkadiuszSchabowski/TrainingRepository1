using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        Console.WriteLine("Podaj liczbę od 1-50");
        bool check = int.TryParse(Console.ReadLine(), out userInput);
        Console.WriteLine();

        if (check && userInput > 0 && userInput < 51)
        {
            for (int i = 1; i < userInput + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowa wartość");
        }
        Console.ReadKey();
    }
}