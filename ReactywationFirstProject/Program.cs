using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OwnTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Mazda mazda = new Mazda();
            Console.WriteLine($"{mazda.Kolor}, {mazda.PredkoscMaksymalna}, {mazda.LiczbaKol}");
            BMW bmw = new BMW();
            Console.WriteLine($"{bmw.Kolor}, {bmw.PredkoscMaksymalna}, {bmw.LiczbaKol}");
            Console.ReadKey();
        }
    }
    class BMW
    {
        private string kolor = "biały";

        private string predkoscMaksymalna = "300km/h";

        private int liczbaKol = 4;

        public string Kolor { get; set; }
        public int LiczbaKol { get; set; }
        public string PredkoscMaksymalna { get; }

        public BMW()
        {
            Kolor = kolor;
            LiczbaKol = liczbaKol;
            PredkoscMaksymalna = predkoscMaksymalna;
        }
    }
    class Mazda
    {
        public Mazda()
        {
            Kolor = kolor;
            PredkoscMaksymalna = predkoscMaksymalna;
            LiczbaKol = liczbaKol;
        }
        private string kolor = "srebrny";
        private string predkoscMaksymalna = "240kmh";
        private int liczbaKol = 4;

        public string Kolor { get; }
        public string PredkoscMaksymalna { get;}

        public int LiczbaKol { get;}

    }
}

