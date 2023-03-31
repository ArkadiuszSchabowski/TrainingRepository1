using System;

namespace Lekcja29
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float sum = 0;
            int i = 0;

            do
            {
                Console.Write("Podaj liczbę: ");
                a = float.Parse(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                sum += a;
                i++;
            } while (a != 0);

            Console.WriteLine("Średnia to: {0}", Math.Round(sum / i, 2));
        }
    }
}
