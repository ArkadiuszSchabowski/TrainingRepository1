using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
        int kumulacja;
        static int money = 50;
        static int day = 0;
        static int tickets = 0;
        static void Main(string[] args)
        {
            ConsoleKey wybor;
            bool flag = true;
            List<int[]> kupon =  new List<int[]>();

            do
            {
                day++;
                Console.WriteLine("Dzień {0}, Twój stan konta wynosi: {1}zł\n", day, money);

                Console.WriteLine("1 - Postaw los {0}/5", tickets);
                Console.WriteLine("2 - Sprawdz los");
                Console.WriteLine("3 - Zakoncz grę");

                wybor = Console.ReadKey().Key;

                if (wybor == ConsoleKey.D1)
                {
                    tickets++;
                    money -= 3;
                    SetTicket();
                }
                if (wybor == ConsoleKey.D2)
                {
                    CheckTicket();
                }
                if (wybor == ConsoleKey.D3)
                {
                    flag = false;
                }

            } while (money >= 3 && tickets < 6 && flag == true);
        }

        private static void CheckTicket()
        {

        }

        private static void SetTicket()
        {
            int[] userNumbers = new int[6];
            bool result = true;
            int number = 0;

            Console.Clear();
            Console.WriteLine($"Kupon nr {tickets}/5");
            Console.WriteLine();
            Console.WriteLine("Wytypuj 6 liczb z przedziału 1-49!\n");

            for (int i = 0; i < userNumbers.Length; i++)
            {
                result = int.TryParse(Console.ReadLine(), out number);

                if (result && number > 0 && number < 50 && !userNumbers.Contains(number))
                {
                    userNumbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa liczba");
                    i--;
                }
            }
            Array.Sort(userNumbers);
            Console.WriteLine();
            foreach (var item in userNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}