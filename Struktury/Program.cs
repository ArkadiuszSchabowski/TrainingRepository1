using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt2D punkt1;
            punkt1.x = 5;

            Console.WriteLine(punkt1.x);
            Console.ReadKey();
        }
    }
    struct Punkt2D
    {
        public int x;
        public int y;
        public void OdlegloscOdSrodka()
        {

        }
    }
}
