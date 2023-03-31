using System;

namespace Lekcja27
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                if (i > 20)
                {
                    break;
                }
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
