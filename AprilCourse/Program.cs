using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Silnia(5));
        Console.ReadKey();
    }
    static int Silnia (int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Silnia(n - 1);
        }
    }
}