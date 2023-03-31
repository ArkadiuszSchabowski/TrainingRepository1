using System;

namespace Lekcja22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj dzień tygodnia: ");
            int a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1: // ==
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia!");
                    break;
            }
        }
    }
}
