using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Console.WriteLine($"Wlaściciel to {card.Owner}");
            Console.ReadKey();
        }
    }
}
