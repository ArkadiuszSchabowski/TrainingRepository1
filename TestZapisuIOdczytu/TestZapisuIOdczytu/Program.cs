using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestZapisuIOdczytu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"../../../zapis2.txt";

            StreamWriter sw = new StreamWriter("../../../zapis.txt");
            Console.WriteLine("Podaj słowo do zapisu");
            sw.WriteLine(Console.ReadLine());
            sw.Close();

            StreamWriter sk = new StreamWriter(path, true);
            Console.WriteLine("Podaj słowo do zapisu");
            sk.WriteLine(Console.ReadLine());
            sk.Close();
        }
    }
}
