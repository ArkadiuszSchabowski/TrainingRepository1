using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzybkiProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            string operation;
            while (true)
            {
                Console.WriteLine("Pierwsza cyfra");
                x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Druga cyfra");
                x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("+, -, *, /");
                operation = Console.ReadLine();

                if (operation == "+")
                    Console.WriteLine(x1 + x2);

                else if(operation == "-")
                    Console.WriteLine(x1 - x2);

                else if (operation == "*")
                    Console.WriteLine(x1 * x2);

                else if (operation == "/")
                    Console.WriteLine(x1 / x2);
                else
                {
                    Console.WriteLine("Zła operacja");
                }
            }
        }
    }
}
