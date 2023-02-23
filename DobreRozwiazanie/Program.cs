using System;
using System.Collections.Generic;
namespace NeverSurrender
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card("Arkadiusz");
            card.registerNewTrace(42, "12.02.2023", "Przygotowanie do lawiny - maraton C#");
            card.registerNewTrace(5, "22.02.2023", "Lawina odparta");
            card.showCard();
            card.GetAccountHistory();
            Console.ReadKey();
        }
    }
    class Card
    {
        private static int cardNumberSeed = 1;
        public string Number { get; }
        public string Owner { get; set; }
        public Card(string owner)
        {
            this.Owner = owner;
            this.Number = cardNumberSeed.ToString().PadLeft(9, '0');
            cardNumberSeed++;
        }
        public void showCard()
        {
            Console.WriteLine();
            Console.WriteLine($"Card {this.Number} was created for {this.Owner}.");
            showAllTraces();
            Console.WriteLine($"\n  Pokonany dystans: {this.Distance}km");
        }
        private List<Trace> allTraces = new List<Trace> { };
        public void registerNewTrace(decimal kilometers, string date, string note)
        {
            var trace = new Trace(kilometers, date, note);
            allTraces.Add(trace);
        }
        public void showAllTraces()
        {
            foreach (var trace in allTraces)
            {
                Console.WriteLine($"  {trace.Date} -{trace.Kilometers,4}km {trace.Note}");
            }
        }
        public decimal Distance
        {
            get
            {
                decimal distance = 0;
                foreach (var trace in allTraces)
                {
                    distance += trace.Kilometers;
                }
                return distance;
            }
        }
        public string GetAccountHistory()
        {
            return allTraces.ToString();
        }
    }
    public class Trace
    {
        public decimal Kilometers { get; }
        public string Date { get; }
        public string Note { get; }
        public Trace(decimal kilometers, string date, string note)
        {
            this.Kilometers = kilometers;
            this.Date = date;
            this.Note = note;
        }
    }
}
