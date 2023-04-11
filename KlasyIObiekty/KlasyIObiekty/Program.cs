using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyIObiekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meble.MebleDrewniane();

            Console.WriteLine();

            Szyba szyba = new Szyba();
            szyba.Szklo();
            Console.ReadKey();
        }
    }
    public class Szyba
    {
        public void Szklo()
        {
            Console.WriteLine("Jestem wykonana ze szkła");
        }
    }

    public static class Meble
    {
        public static void MebleDrewniane()
        {
            Console.WriteLine("Jestem wykonany z drzewa");
        }
    }
}
