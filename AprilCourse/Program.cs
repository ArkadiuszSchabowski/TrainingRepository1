using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AprilCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: { byte.MinValue}, { byte.MaxValue}");
            Console.WriteLine($"short: {short.MinValue}, {short.MaxValue}");
            Console.WriteLine($"int: {int.MinValue}, {int.MaxValue}");
            Console.WriteLine($"long: {long.MinValue}, {long.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"float: {float.MinValue}, {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue}, {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue}, {decimal.MaxValue}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}