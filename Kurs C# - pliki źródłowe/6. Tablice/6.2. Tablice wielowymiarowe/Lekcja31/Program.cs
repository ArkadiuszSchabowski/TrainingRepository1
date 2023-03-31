﻿using System;

namespace Lekcja31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[2, 3];
            array2D[0, 0] = 1;
            array2D[1, 2] = 9;
            Console.WriteLine(array2D[0, 0]);
            Console.WriteLine(array2D[1, 2]);
            Console.WriteLine("\nWymiary:");
            Console.WriteLine(array2D.Length);
            Console.WriteLine(array2D.GetLength(0));
            Console.WriteLine(array2D.GetLength(1));

            Console.WriteLine("\nArray 2D:");
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nArray 3D:");
            int[,,] array3D = new int[2, 2, 2];
            array3D[0, 1, 0] = 9;
            Console.WriteLine(array3D[0, 1, 0]);

            Console.WriteLine("\nText Array:");
            string[,] textArray = { { "Hello", "World" }, {"Witaj", "Świecie" } };
            
            Console.WriteLine(textArray[0, 0] + " " + textArray[0, 1]);
            Console.WriteLine(textArray[1, 0] + " " + textArray[1, 1]);

            Console.WriteLine("\nForeach:");

            foreach (var item in textArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
