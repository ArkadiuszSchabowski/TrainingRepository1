using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrainingC_Skills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 2;
            string userAge = (age < 18) ? "Użytkownik ma mniej niż 18 lat" : "Użytkownik ma ponad 18 lat";
            Console.WriteLine(userAge);
            Console.ReadLine();
        }
    }
}
