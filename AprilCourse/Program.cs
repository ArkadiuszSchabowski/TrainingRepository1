using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zgadnij czy dane słowo jest palindromem");
        string word = Console.ReadLine().ToUpper().Replace(" ", "");
        bool isTrue = true;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                isTrue = false;
                break;
            }
        }

        if (isTrue)
        {
            Console.WriteLine("Słowo jest palindromem");
        }
        else
        {
            Console.WriteLine("Słowo nie jest palindromem");
        }
        Console.ReadKey();
    }
}