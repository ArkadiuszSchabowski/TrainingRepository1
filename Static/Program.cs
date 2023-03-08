using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek = new Czlowiek();
            Console.WriteLine(czlowiek.imie);
            Czlowiek czlowiek2 = new Czlowiek();
            czlowiek2.imie = "Bartek";
            Console.WriteLine(czlowiek2.imie);
            Czlowiek czlowiek3 = new Czlowiek();
            Console.WriteLine(czlowiek3.imie);
            Console.ReadKey();
        }
    }
    class Czlowiek
    {
        public string imie = "Adrian";
    }
}
