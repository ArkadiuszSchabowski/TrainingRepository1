using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Legitymacja legitymacja = new Legitymacja();
            Console.WriteLine($"Wlasciciel legitymacji: {legitymacja.Wlasciciel}, numer karty: {legitymacja.Numer}");
            Console.ReadKey();
            Trasa klasaB = new Trasa();
            Trasa.NumerTrasy();

        }
    }
    public class Legitymacja
    {
        private int numer = 4691243;

        private string wlasciciel = "Kropka";

        public int Numer { get; set; }

        public string Wlasciciel { get; set; }

        public Legitymacja()
        {
            this.Numer = numer;
            this.Wlasciciel = wlasciciel;
        }
    }
    public class Trasa
    {
        public static void NumerTrasy()
        {
            double kilometry = 0;
            string notatki = "";
            int iloscWycieczek = 0;
            iloscWycieczek = int.Parse(Console.ReadLine());
            for (int i = 0; i < iloscWycieczek; i++)
            {
                Console.WriteLine("Podaj ilość przebytych km");
                kilometry = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj notatki z wycieczki");
                notatki = Console.ReadLine();
                kilometry += kilometry + i;
                Console.WriteLine(kilometry);
            }
        }
    }
}
