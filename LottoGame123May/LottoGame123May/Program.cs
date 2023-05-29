using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame123May
{
    public static class Program
    {
        static int balance = 20;
        static int number1, number2, number3, number4, number5, number6;
        static int comNumber1, comNumber2, comNumber3, comNumber4, comNumber5, comNumber6;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lotto Game\n");
            Console.WriteLine();
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine($"Your balance is {balance}$\n");
            Console.WriteLine("Your tickets:\n");

            Console.WriteLine("1. Send a ticket - 2$");
            Console.WriteLine("2. Check a results");
            Console.WriteLine("3. Quit Game");

            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    SendATicket();
                    break;
                case ConsoleKey.D2:
                    CheckedAResults();
                    break;
                case ConsoleKey.D3:
                    Quitgame();
                    break;
                default:
                    break;
            }
        }
        static void SendATicket()
        {
            if (balance > 2)
            {
                GoodTicket();
                balance -= 2;
                Menu();
            }
            else
            {
                Console.WriteLine("Sorry you dont have money enough!");
                Menu();
            }
        }


        private static void GoodTicket()
        {
            bool correct;


            correct = int.TryParse(Console.ReadLine(), out number1);
            if (correct)
            {

            }
            else
            {
                Console.WriteLine("Wrong value, select the correct value please!");
            }
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());
            number4 = int.Parse(Console.ReadLine());
            number5 = int.Parse(Console.ReadLine());
            number6 = int.Parse(Console.ReadLine());
        }

        private static void CheckedAResults()
        {
            comNumber1 = rnd.Next(1, 50);
            comNumber2 = rnd.Next(1, 50);
            comNumber3 = rnd.Next(1, 50);
            comNumber4 = rnd.Next(1, 50);
            comNumber5 = rnd.Next(1, 50);
            comNumber6 = rnd.Next(1, 50);

            Console.WriteLine($"{comNumber1}, {comNumber1}, {comNumber1}, {comNumber1},{comNumber1},,{comNumber1},");
        }

        private static void Quitgame()
        {

        }
    }
}
