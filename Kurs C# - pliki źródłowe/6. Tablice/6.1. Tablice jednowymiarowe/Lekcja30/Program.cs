using System;

namespace Lekcja30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5; // Ostatni

            Console.WriteLine("Length: {0}", array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();

            char[] array2 = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char item in array2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
