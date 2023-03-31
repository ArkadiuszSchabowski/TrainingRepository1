using System;

namespace Lekcja72
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 10, -7, 8, 3, 0, -6, -10, 2 };
            Array.Sort(arr);
            Array.Reverse(arr);
            arr = Array.FindAll(arr, x => x % 2 == 0);
            Array.Resize(ref arr, 10);
            Array.Clear(arr, 0, 1);
            //arr = Array.Empty<int>();
            Array.ForEach(arr, x => Console.WriteLine(x));
            Console.WriteLine(Array.Exists(arr, x => x == -10));
            Console.WriteLine(Array.Exists(arr, x => x == 10));
            Console.WriteLine(Array.IndexOf(arr, -10));    
        }
    }
}
