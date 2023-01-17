using System;

namespace BladZnaleziony
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = ("Świnko");
            Console.WriteLine("Jak się nazywasz?");
            UserName = Console.ReadLine();
            Console.WriteLine("Hey " + UserName);
            Console.WriteLine("Dobrego dnia " + UserName);
                }
    }
}
