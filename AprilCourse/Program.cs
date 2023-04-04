using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Komputer wylosował liczbę z przedziału 1-10.\nSpróbuj ją odgadnąć");
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 11);
            int userNumber = 0;
            int razy = 0;

            do
            {
                bool check = int.TryParse(Console.ReadLine(), out userNumber);
                Console.WriteLine();

                if (!check || userNumber < 1 || userNumber > 10)
                {
                    Console.WriteLine("Nieprawidłowa wartość");
                }
                else
                {
                    razy++;
                    if (userNumber < computerNumber)
                    {
                        Console.WriteLine("Twoja liczba jest mniejsza od wylosowanej");
                    }
                    else if (userNumber > computerNumber)
                    {
                        Console.WriteLine("Twoja liczba jest większa od wylosowanej");
                    }
                }
            } while (userNumber != computerNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Brawo udało się odgadnąć liczbę za {razy} razem.");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadKey();
        }
    }
}