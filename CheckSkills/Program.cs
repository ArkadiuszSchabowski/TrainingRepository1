using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSkills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1 - Policz srednia z listy
            FirstExcercise();
            //Zadanie2 -Policz srednia z tabeli
            //SecondExercise();
            //Zadanie3 -Narysuj drabine z X w konsoli
            //ThirdExercise();
            //Zadanie4 -Sprawdz czy dane slowo jest palindromem
            //Palindrom();
            //Zadanie5 -Utworz kolekcje od 1 - 100.Dla argumentu 3 wypisz Fizz, dla 5 wypisz Buzz, dla 15 FizzBuzz.
            //Nie wypisuj liczb jesli argument jest spelniony.
            //FizzBuzz();
        }
        static void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 ==0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        static void Palindrom()
        {
            Console.WriteLine("Podaj słowo");
            string word = Console.ReadLine();
            word.ToLower().Replace(" ", "");
            bool isPalindrom = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length -1 - i])
                {
                    isPalindrom = false;
                }
            }
            if(isPalindrom)
            {
                Console.WriteLine("Słowo jest palindromem");
            }
            else
            {
                Console.WriteLine("Słowo nie jest palindromem");
            }
            Console.ReadKey();
        }

        static void ThirdExercise()
        {
            Console.WriteLine("Podaj wysokość drabiny");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if(j ==0 || j == height-1)
                        {
                            Console.Write("X");
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

        static void SecondExercise()
        {
            int[] table = new int[5] {3,6,1,2,4};
            double sum = 0;
            double srednia = 0;

            for (int i = 0; i < table.Length; i++)
            {
                sum += table[i];
            }
            srednia = sum / table.Length;
            Console.WriteLine($"Srednia ocen to {srednia}.");
            Console.ReadKey();
        }
        static void FirstExcercise()
        {
            ArrayList lista = new ArrayList();
            lista.Add(4);
            lista.Add(5);
            lista.Add(2);
            lista.Add(3);

            double sum = 0;
            double srednia = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                sum += sum;
            }

            srednia = sum / lista.Count;
            Console.ReadKey();

        }
    }
}
