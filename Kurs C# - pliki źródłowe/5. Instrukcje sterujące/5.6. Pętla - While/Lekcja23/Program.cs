using System;

namespace Lekcja23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());
            
            int i = 1;

            while (i <= a)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
