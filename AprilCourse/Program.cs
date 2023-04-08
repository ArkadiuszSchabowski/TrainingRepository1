using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int[] array = new int[1];
        array[0] = 1;
        Test(ref a, array);
        Console.WriteLine($"a = {a}\narray = {array[0]}");
        Console.ReadKey();
    }
    static void Test(ref int a, int[] array)
    {
        a = 9;
        array[0] = 9;
    }
}