using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverSurrender
{
    public class Card
    {
        private static int cardNumberSeed = 1234567890;
        static void Main(string[] args)
        {
            var card = new Card("Arkadiusz");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.");
        }
        public string Number { get; }
        public string Owner { get; set; }

        public void RegisterNewTrace(decimal kilometers, DateTime date, string note)
        {
            var trace = new Trace(kilometers, date, note);
            Console.WriteLine(trace);
            allTraces.Add(trace);
        }
        public Card(string owner)
        {
            this.Owner = owner;
            this.Number = cardNumberSeed.ToString();
            cardNumberSeed++;
        }
        private List<Trace> allTraces = new List<Trace> {};
        
        public decimal Distance
        {
            get
            {
                decimal distance = 10;
                foreach (var item in allTraces)
                {
                    distance += item.Kilometers;
                }

                return distance;
            }
        }
        public class Trace
        {
            public decimal Kilometers { get; }

            public DateTime Date { get; }
            public string Notes { get; }

            public Trace(decimal kilometers, DateTime date, string note)
            {
                this.Kilometers = 10;
                this.Date = DateTime.Now;
                this.Notes = "notatki";
            }
        }
    }
}