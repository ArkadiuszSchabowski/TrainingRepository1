using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetAva
{
    class Osoba
    {
        private int _wiek;

        // właściwość
        public int Wiek
        {
            get
            {
                return _wiek;
            }
            set
            {
                _wiek = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba Karol = new Osoba();

            Karol.Wiek = 21;
            System.Console.WriteLine(Karol.Wiek);

            System.Console.ReadKey();
        }
    }
}
