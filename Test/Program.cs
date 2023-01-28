using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Test
{

    class Osoba
    {
        public int _wiek;
        public int PobierzWiek()
        {
            return _wiek;
        }

        public void UstawWiek(int wiek)
        {
            wiek = _wiek;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba Arek = new Osoba();

            Arek.UstawWiek(21);
            System.Console.WriteLine(Arek.PobierzWiek());
            Console.ReadKey();

        }
    }
}