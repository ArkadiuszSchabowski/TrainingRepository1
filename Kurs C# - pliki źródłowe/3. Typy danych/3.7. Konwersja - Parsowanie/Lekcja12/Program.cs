using System;

namespace Lekcja12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konwersja [Parsowanie]

            string tekst = Console.ReadLine();
            int varInt;
            //varInt = int.Parse(tekst);
            //Console.WriteLine(varInt);
            
            float varFloat;
            bool success = float.TryParse(tekst, out varFloat);
            Console.WriteLine($"{varFloat} - {success}");

            tekst = varFloat.ToString();
            tekst = true.ToString();
            Console.WriteLine(tekst);
        }
    }
}
