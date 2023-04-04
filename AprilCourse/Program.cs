using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array2D = new int[2, 3];

        array2D[0, 0] = 4;
        array2D[0, 1] = 7;
        array2D[0, 2] = 6;
        array2D[1, 0] = 9;
        array2D[1, 1] = 2;
        array2D[1, 2] = 3;

        foreach (var item in array2D)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}