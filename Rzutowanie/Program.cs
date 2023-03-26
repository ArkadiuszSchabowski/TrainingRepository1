using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rzutowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            double d = 5.1;

            i = (int)d;

            Console.WriteLine(i);
            Console.ReadKey();




        }
    }
}
