using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hej Ekipa z Kursu 8k.";
            Console.WriteLine(hello.StartsWith("Hello"));
            Console.WriteLine(hello.EndsWith("6k."));
            Console.ReadKey();
        }
    }
}
