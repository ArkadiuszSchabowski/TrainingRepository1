using System;
using System.Collections.Generic;

namespace Lekcja79
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nIlość: {stack.Count}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Ilość: {stack.Count}");
            Console.WriteLine(stack.Peek());
            Console.WriteLine($"Ilość: {stack.Count}");
            stack.Push(10);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Ilość: {stack.Count}");
        }
    }
}
