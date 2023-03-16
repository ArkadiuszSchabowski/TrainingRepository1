using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCrazy
{
    public class Program
    {
        int kumulacja;
        static void Main(string[] args)
        {
            Menu();
            //UserNumbers();
            //ComputerNumbers();
            //CheckNumbers();
        }

        public static void Menu()
        {
            Console.WriteLine("Program Lotto - Menu Gry.\nWybierz jedną z opcji");
            Console.WriteLine("1.Postaw kupon");
            Console.WriteLine("2.Sprawdź kupon");
            Console.WriteLine("3. Wyjście z programu");

            bool flaga = true;

            while (flaga)
            {
                ConsoleKey wybor;
                wybor = Console.ReadKey().Key;

                if (wybor == ConsoleKey.D1)
                {
                    Console.WriteLine("Postaw Kupon");
                }
                if (wybor == ConsoleKey.D2)
                {
                    Console.WriteLine("Sprawdź kupon");
                }
                if (wybor == ConsoleKey.D3)
                {
                    Console.WriteLine("Wyjście z programu");
                    flaga = false;
                }
            }
        }

        private static void CheckNumbers()
        {

        }

        public static void ComputerNumbers()
        {
            int[] computerNumbers = new int[6];
            int number;
            Random rnd = new Random();

            for (int i = 0; i < computerNumbers.Length; i++)
            {
                number = rnd.Next(1, 50);
                computerNumbers[i] = number;
            }

            Array.Sort(computerNumbers);
            foreach (var item in computerNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static void UserNumbers()
        {
            int number = 0;
            int[] userNumbers = new int[6];

            Console.WriteLine("Zgadnij 6 liczb z przedziału 1-49. Przewidziane atrakcyjne nagrody");
            for (int i = 0; i < userNumbers.Length; i++)
            {
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (result && (number > 0 && number < 50) && !userNumbers.Contains(number))
                {
                    userNumbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Podałeś złą wartość!");
                    i--;
                }
            }
            Array.Sort(userNumbers);
            Console.WriteLine();
            foreach (var item in userNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

