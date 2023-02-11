using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalanche.Properties
{
    public class Card
    {
        public static void Main(string[] args)
        {

            var card = new Card("Arkadiusz");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.");
            Console.ReadKey();
        }

        private static int cardNumberSeed = 1234567890;

        public string Number { get; }
        public string Owner { get; set; }

        public void RegisterNewTrace(decimal kilometers, string note)
        {
            var trace = new Trace(kilometers, note);
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
                decimal distance = 0;
                foreach (var item in allTraces)
                {
                    distance += item.Kilometers;
                }
                return distance;
            }
            
        }
    }
}