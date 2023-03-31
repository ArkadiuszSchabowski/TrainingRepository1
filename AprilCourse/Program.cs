using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime data = DateTime.Now;
            Console.WriteLine("Podaj datę urodzenia");
            string dateOfBirth = Console.ReadLine();

            TimeSpan uplynelo = data - DateTime.Parse(dateOfBirth);

            Console.WriteLine(uplynelo);
            Console.ReadLine();


        }
    }
}