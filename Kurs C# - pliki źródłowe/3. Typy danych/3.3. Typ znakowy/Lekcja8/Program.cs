using System;

namespace Lekcja8
{
    class Program
    {
        static void Main(string[] args)
        {
            // TYPY DANYCH [Znakowy]

            char varChar = 'a';
            Console.WriteLine(varChar.ToString());
            Console.WriteLine((int)varChar);

            string varString = "\nJakiś tekst!".ToUpper();
            Console.WriteLine(varString + "\"\\ - " + varString);
            int a = 3;
            Console.WriteLine(a.ToString());
        }
    }
}
