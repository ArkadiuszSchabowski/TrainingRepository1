using System;
using System.Threading;

namespace Lekcja71
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(LongMethod));
            Thread t2 = new Thread(new ParameterizedThreadStart(LongMethod));
            
            t1.Start(10);
            t2.Start(10);
        }

        static void LongMethod(object n)
        {
            for (int i = 0; i < (int)n; i++)
            {
                Console.WriteLine($"ID {Thread.CurrentThread.ManagedThreadId} : {i}");
            }
        }
    }
}
