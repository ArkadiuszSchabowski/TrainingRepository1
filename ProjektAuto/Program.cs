using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektAuto
{
    class Samochod

    {
        string _rodzaj;

        public void UstawRodzaj(string rodzaj)
        {
            rodzaj = _rodzaj;
        }
        public string WyswietlRodzaj()

        {
            return _rodzaj;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod Mazda = new Samochod();

            Mazda.UstawRodzaj(Console.ReadLine());
            Console.WriteLine(Mazda.WyswietlRodzaj());
            Console.ReadKey();
        }
    }
}
