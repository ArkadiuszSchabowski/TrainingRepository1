using System;
using System.Collections.Generic;

namespace Lekcja78
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Poniedziałek");
            queue.Enqueue("Wtorek");
            queue.Enqueue("Środa");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nIlość: {queue.Count}");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine($"Ilość: {queue.Count}");

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine($"Ilość: {queue.Count}");
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue("Czwartek");
            Console.WriteLine($"Ilość: {queue.Count}");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine($"Ilość: {queue.Count}");

            Console.WriteLine(queue.Peek());

        }
    }
}
