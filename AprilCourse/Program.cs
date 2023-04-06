using System;

class Program
{
    static void Main(string[] args)
    {
        Params("{0} {1} {2}", "Hello", "World", "!!!");

        Console.ReadKey();
    }

    static void Params(string text, params string[] arg)
    {
        for (int i = 0; i < arg.Length; i++)
        {
            text = text.Replace("{" +i + "}", arg[i]);
        }
        Console.WriteLine(text);
    }
}