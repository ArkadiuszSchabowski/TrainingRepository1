using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest
{
    internal class Program
    {
        // Napisz program, który obliczy sumę wszystkich liczb całkowitych od 1 do 1000, które są podzielne przez 3 lub 5.
        static void Main(string[] args)
        {
            //SecondExercise();
            FourthExercise();
            //ThirdExercise();
        }
        static void FourthExercise()
        {
            Console.WriteLine("Podaj slowo, a ja je odwroce!");

            string word = Console.ReadLine();
            string userIput;

            Console.ReadKey();
        }
        static void SecondExercise()
        {
            Console.WriteLine("Wprowadz slowo, a sprawdze czy jest palindromem");

            string word = Console.ReadLine();
            string userInput = word.ToUpper();

            bool isPalindrom = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (userInput[i] != userInput[(word.Length - 1) - i])
                {
                    isPalindrom = false;
                    break;
                }
            }

            if (isPalindrom)
            {
                Console.WriteLine("Twoje slowo jest palindromem");
            }
            else
            {
                Console.WriteLine("Twoje slowo nie jest palindromem");
            }
            Console.ReadKey();
        }
        static void FirstExercise()
        {
            int sum = 0;

            for (int i = 1; i < 1001; i++)
            {

                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine($"Suma liczb calkowitych od 1 do 1000 ktore sa podzielne przez 3 lub 5 wynosi {sum}.");
            Console.ReadKey();
        }
    }
}
