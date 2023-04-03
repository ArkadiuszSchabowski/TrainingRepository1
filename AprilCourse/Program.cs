using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj dzień tygodnia");
        int userInput = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                Console.WriteLine("Twój wybór to poniedziałek");
                break;
            case 2:
                Console.WriteLine("Twój wybór to wtorek");
                break;
            case 3:
                Console.WriteLine("Twój wybór to środa");
                break;
            case 4:
                Console.WriteLine("Twój wybór to czwartek");
                break;
            case 5:
                Console.WriteLine("Twój wybór to piątek");
                break;
            case 6:
                Console.WriteLine("Twój wybór to sobota");
                break;
            case 7:
                Console.WriteLine("Twój wybór to niedziela");
                break;
        }
        Console.ReadLine();
    }
}