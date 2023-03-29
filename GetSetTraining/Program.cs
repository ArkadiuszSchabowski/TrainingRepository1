using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card = new Card("Arkadiusz");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.");
            Console.ReadKey();
        }
    }
    class Card
    {
        private static int cardNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }

        public Card(string owner)
        {
            this.Owner = owner;
            this.Number = cardNumberSeed.ToString();
        }

        public void RegisterNewTrace(decimal kilometers, DateTime date, string note)
        {
        }
    }
}
