using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayRepeats
{
    /* ConsoleApp:
     * 1. Czy slowo jest Palindromem.
     * 2. Drabina z gwiazdek i X.
     * 3. Gra Lotto
     * 4. Milionerzy z podzialem na klasy
     * 5. Odgadnij liczbe wylosowana przez komputer
     * 6. Papier, Kamien, Nozyce
     * 
     * WindowsFormApp:
     * 1.Kalkulator
     * 2.MemoryGame
     * 3.Quiz
     * 4.Kurczak lapiacy jajka
     * 5.Lista kontaktow
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            StonePaperScissors();
        }
        static void UserSelection()
        {

        }
        static void StonePaperScissors()
        {
            string userSelection = "";
            string computerSelection = "";
            int computerNumber;
            int computerScore = 0;
            int userScore = 0;

            Random rnd = new Random();

            Console.WriteLine("Welcome to the game: rock, paper, scissors!\n" + "You will play against your computer!\n");

            while (computerScore != 10 && userScore != 10)
            {
                Console.Clear();
                Console.WriteLine($"User {userScore} : {computerScore} Computer\n");

                Console.WriteLine("Choose your tool:\n");
                Console.WriteLine("1.Rock\n2.Paper\n3.Scissors\n");

                ConsoleKey wybor = Console.ReadKey().Key;

                switch (wybor)
                {
                    case ConsoleKey.D1:
                        userSelection = "rock";
                        break;
                    case ConsoleKey.D2:
                        userSelection = "paper";
                        break;
                    case ConsoleKey.D3:
                        userSelection = "scissors";
                        break;
                    default:
                        break;
                }

                computerNumber = rnd.Next(1, 4);

                switch (computerNumber)
                {
                    case 1:
                        computerSelection = "rock";
                        break;
                    case 2:
                        computerSelection = "paper";
                        break;
                    case 3:
                        computerSelection = "scissors";
                        break;
                }

                Console.WriteLine($"\n\nYour selection is: {userSelection}");
                Console.WriteLine($"Computer selection is: {computerSelection}");
                Console.WriteLine();

                if (computerSelection == "rock" && userSelection == "rock")
                {
                    Console.WriteLine("Draw");
                }
                if (computerSelection == "paper" && userSelection == "paper")
                {
                    Console.WriteLine("Draw");
                }
                if (computerSelection == "scissors" && userSelection == "scissors")
                {
                    Console.WriteLine("Draw");
                }

                if (computerSelection == "rock" && userSelection == "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    computerScore++;
                    Console.WriteLine("The computer wins");
                }
                if (computerSelection == "paper" && userSelection == "rock")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    computerScore++;
                    Console.WriteLine("The computer wins");
                }
                if (computerSelection == "scissors" && userSelection == "paper")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    computerScore++;
                    Console.WriteLine("The computer wins");
                }

                if (computerSelection == "scissors" && userSelection == "rock")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    userScore++;
                    Console.WriteLine("The user wins");
                }
                if (computerSelection == "rock" && userSelection == "paper")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    userScore++;
                    Console.WriteLine("The user wins");
                }
                if (computerSelection == "paper" && userSelection == "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    userScore++;
                    Console.WriteLine("The user wins");
                }
                Console.ResetColor();
                Console.WriteLine("\nIf you want play next round press any button.");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Your result is:\n");
            Console.WriteLine($"User {userScore} : {computerScore} Computer\n");
            Console.ReadKey();
        }
    }
}
