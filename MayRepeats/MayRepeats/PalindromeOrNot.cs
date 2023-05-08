using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayRepeats
{
    public static class PalindromeOrNot
    {
        public static void CheckIfWordIsAPalindrome()
        {
            bool isPalindrome = true;

            Console.WriteLine("Input word or sentence. I will check if this word is a palindrome!");

            string word = Console.ReadLine().ToLower().Replace(" ", "");

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Your word is a palindrome!");
            }

            if (!isPalindrome)
            {
                Console.WriteLine("Your word is not a palindrome!");
            }
            Console.ReadKey();
        }
    }
}
