using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dzien urodzin");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj miesiąc urodzin");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj rok urodzin");
            int year = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);

            DateTime dateTimeNow = DateTime.Now;

            TimeSpan howLong = dateTimeNow - dateOfBirth;

            Console.WriteLine(howLong);

            Console.ReadKey();
        }
    }
}
