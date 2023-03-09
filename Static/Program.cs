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
            Czlowiek czlowiek = new Czlowiek("Dominika", "Króliczek");
            czlowiek.PrzedstawSie();
            Console.ReadKey();
        }
    }
    class Czlowiek
    {
        public string imie = "Paulina";
        public string nazwisko = "Kropka";

        public Czlowiek()
        {

        }
        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine($"Nazywam się: {imie} {nazwisko}");
        }
    }

}
