using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba Dominika = new Osoba();
            Console.WriteLine($"Wiek Dominiki to : {Dominika.Wiek}");
            Console.WriteLine($"Wzrost Dominiki to : {Dominika.Wzrost}");
            Console.WriteLine($"Waga Dominiki to : {Dominika.Waga}");

            ArrayList zainteresowania = new ArrayList();
            zainteresowania.Add("sex");
            zainteresowania.Add("rozwój osobisty");
            zainteresowania.Add("taniec na rurze");

            Console.WriteLine($"Długość zainteresować to: {zainteresowania.Count}");
            Console.WriteLine(zainteresowania);
            Console.ReadKey();

        }
    }
    class Osoba
    {
        public Osoba()
        {
            Wiek = wiek;
            Wzrost = wzrost;
            Waga = waga;
        }
        private int wiek = 20;
        private string waga = "55kg";
        private string wzrost = "168cm";

        public int Wiek { get; }

        public string Wzrost { get; }

        public string Waga { get; set; }

    }
}
