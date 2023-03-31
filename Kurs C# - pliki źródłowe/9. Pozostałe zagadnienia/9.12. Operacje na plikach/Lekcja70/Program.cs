using System;
using System.IO;

namespace Lekcja70
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("../../../file.txt", true);
            sw.WriteLine(Console.ReadLine());
            sw.Close();

            Console.WriteLine("\nZawartość pliku:");
            StreamReader sr = new StreamReader("../../../file.txt");

            string line;
            
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            sr.Close();
        }
    }
}
