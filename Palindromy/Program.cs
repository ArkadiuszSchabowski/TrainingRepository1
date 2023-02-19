using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            bool isPalindrom = true;

            Console.WriteLine("Podaj słowo - sprawdzimy czy jest palindronem");
            word = Console.ReadLine().ToUpper().Replace(" ", "");
            Console.WriteLine(word);

            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            if(isPalindrom)
            {
                Console.WriteLine("Twoje słowo jest palindronem");
            }
            else
            {
                Console.WriteLine("Twoje słowo nie jest palindronem");
            }
            Console.ReadKey();
        }

    }
}
