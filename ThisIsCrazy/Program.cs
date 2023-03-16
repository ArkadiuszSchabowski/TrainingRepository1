using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCrazy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Zgadnij 6 liczb z przedziału 1-49. Przewidziane atrakcyjne nagrody");
            bool result = int.TryParse(Console.ReadLine(), out number);
            if (result && (number>0 && number < 50))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Podałeś złą liczbę!");
            }
            Console.ReadKey();

        }
    }
}
