using System;
using System.Collections.Generic;
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
            //UserNumbers();
            ComputerNumbers();
        }

        private static void ComputerNumbers()
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

        private static void UserNumbers()
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

