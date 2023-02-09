using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expedition8k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello;

            hello = "Hej Ekipa";

            hello = hello.Replace("Hej", "Good Morning");
            hello = hello.Replace("Ekipa", "Team");
            Console.WriteLine(hello);

            Console.ReadKey();
        }
    }
}
