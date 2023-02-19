using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisions8k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise3();
            //Exercise4();
            //LadderHeight();
            //Palindromes();
            //CheckNumberGame();
        }
        static void CheckNumberGame()
        {
            int number, random;
            int howManyTimes = 0;
            Random rnd = new Random();
            random = rnd.Next(1, 11);

            Console.WriteLine("Zgadnij liczbę wylosowaną przez komputer z zakresu 1-10.");

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Liczba z poza zakresu");
                }
                else
                {
                    howManyTimes++;
                    if (number > random)
                    {
                        Console.WriteLine("Twoja liczba jest za duża");
                    }
                    else if (number < random)
                    {
                        Console.WriteLine("Twoja liczba jest za mała");
                    }
                    else
                    {
                        Console.WriteLine($"Brawo zgadłeś wylosowaną liczbę za {howManyTimes} razem");
                        Console.ReadKey();
                    }
                }
            }
            while (number != random);

        }
        static void Palindromes()
        {
            bool isPalindrom = true;
            string word;
            Console.WriteLine("Wpisz wyraz-sprawdzimy czy jest palindromem");
            word = Console.ReadLine().ToUpper().Replace(" ", "");

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrom = false;
                }
            }
            if (isPalindrom)
            {
                Console.WriteLine("Twoje słowo jest palindromem");
            }
            else
            {
                Console.WriteLine("Twoje słowo nie jest palindromem");
            }
            Console.ReadKey();
        }

        static void LadderHeight()
        {
            int ladderHeight = 0;
            Console.WriteLine("Podaj wysokość drabiny");
            ladderHeight = int.Parse(Console.ReadLine());

            for (int i = 0; i < ladderHeight; i++)
            {
                for (int j = 0; j < ladderHeight; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 0 || j == ladderHeight - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        static void Exercise4()
        //       Znasz instrukcję if oraz konstrukcje pętli.Przed Tobą następujące zadanie:Napisz przy użyciu                 pętli oraz instrukcji if kod, który znajdzie sumę wszystkich liczb całkowitych od 1 do 30, które             są podzielne przez 7. Podziel się swoim kodem na naszej grupie na FB. Wskazówka: użyj modulo.
        {
            int checkresult = 7 + 14 + 21 + 28;
            Console.WriteLine("Checkresult is " + checkresult);

            int sum = 0;

            for (int i = 1; i < 31; i++)
            {
                if (i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"Twoja suma to : {sum}");
            Console.ReadKey();
        }
        static void Exercise3()
        {
            double r = 2.5;
            double obszarKola = r * r;
            double PI = Math.PI;
            double poleKola = obszarKola * PI;
            Console.WriteLine("Pole naszego koła wynosi: " + Math.Round(poleKola, 2));
            Console.ReadKey();
        }
    }
}
