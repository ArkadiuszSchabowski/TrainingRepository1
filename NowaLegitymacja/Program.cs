using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowaLegitymacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Console.WriteLine($"Właściciel to {card.Owner}, numer karty to: {card.Number}");
            Console.ReadKey();
        }
    }
    public class Card
    {
        private int numerKarty = 464291;

        private string owner;

        public string Owner { get; set; }

        public int Number { get; set; }

        public Card()
        {
            this.Number = numerKarty;
            this.Owner = owner;
        }
    }
}