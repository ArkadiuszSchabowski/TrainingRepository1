using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0} {1} {2}", "Hello", "World", "!!!");
        Print("{0} {1} {2}", "Hello", "World", "!!!");
        Console.ReadKey();
    }
    static void Print (string text, params string[] arg)
    {
        for (int i = 0; i < arg.Length; i++)
        {
            text = text.Replace("{"+ i +"}", arg[i]);
        }
        Console.WriteLine(text);
    }
}