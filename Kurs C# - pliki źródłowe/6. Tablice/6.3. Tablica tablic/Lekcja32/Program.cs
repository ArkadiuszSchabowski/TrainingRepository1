using System;

namespace Lekcja32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[5];
            array[1] = new int[3];
            array[2] = new int[7];

            array[0][0] = 1;
            array[2][6] = 9;

            Console.WriteLine(array[0][0]);
            Console.WriteLine(array[2][6]);

            Console.WriteLine("\nFor:");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nForeach:");

            foreach (int[] array2 in array)
            {
                foreach (int item in array2)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
