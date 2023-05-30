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
        static int startBalance = balance;
        static int userNumber1, userNumber2, userNumber3, userNumber4, userNumber5, userNumber6;
        static int comNumber1, comNumber2, comNumber3, comNumber4, comNumber5, comNumber6;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine($"Your balance is {balance}$\n");
            Console.WriteLine("Your tickets:\n");

            Console.WriteLine("1. Send lottery ticket - 2$");
            Console.WriteLine("2. Check a results");
            Console.WriteLine("3. Quit Game");

            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    SendLotteryTicket();
                    break;
                case ConsoleKey.D2:
                    CheckResults();
                    break;
                case ConsoleKey.D3:
                    QuitGame();
                    break;
                default:
                    Console.WriteLine("Select the correct option, please!\n");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }
        static void SendLotteryTicket()
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

            for (int i = 0; i < 7; i++)
            {
                correct = int.TryParse(Console.ReadLine(), out userNumber1);
                if (correct && userNumber1 > 0 && userNumber1 < 50)
                {
                }
                else
                {
                    Console.WriteLine("Wrong value, select the correct value please!");
                }
                userNumber2 = int.Parse(Console.ReadLine());
                userNumber3 = int.Parse(Console.ReadLine());
                userNumber4 = int.Parse(Console.ReadLine());
                userNumber5 = int.Parse(Console.ReadLine());
                userNumber6 = int.Parse(Console.ReadLine());
            }
        }

        private static void CheckResults()
        {
            comNumber1 = rnd.Next(1, 50);
            comNumber2 = rnd.Next(1, 50);
            comNumber3 = rnd.Next(1, 50);
            comNumber4 = rnd.Next(1, 50);
            comNumber5 = rnd.Next(1, 50);
            comNumber6 = rnd.Next(1, 50);

            Console.WriteLine("Computer numbers are:\n");
            Console.WriteLine($"{comNumber1}, {comNumber2}, {comNumber3}, {comNumber4},{comNumber5},,{comNumber6}.");
        }
        private static void QuitGame()
        {
            Console.WriteLine($"Thank You for your game. Your result is: {balance - startBalance}");
            Console.ReadKey();
        }
    }
}
