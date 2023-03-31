using System;

namespace Lekcja42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int[] array;
            //array[0] = 1;
            int b = Test(out a, out array);
            Console.WriteLine($"a = {a}\narray = {array[0]}");

            int c = 9;
            bool check = int.TryParse("abc", out c);
            Console.WriteLine(c);
        }

        static int Test(out int a, out int[] array)
        {
            a = 9;
            array = new int[1];
            array[0] = 9;
            return 0;
        }
    }
}
