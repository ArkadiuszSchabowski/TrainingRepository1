using System;

class Program
{
    static void Main(string[] args)
    {
        int wynik = Test(1,1);
        Console.WriteLine(wynik);
        Console.ReadKey();
    }
    static int Test(int x, int y)
    {
        return x + y;
    }
}