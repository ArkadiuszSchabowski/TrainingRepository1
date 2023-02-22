using System;
using System.Collections.Generic;

namespace NeverSurrender
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card("Arkadiusz");
            Console.WriteLine($"Karta użytkownika: { card.Owner}, numer karty {card.Number}");
            card.registerNewTrace(10, DateTime.Now.AddDays(-1), "Lorem ipsum 1");
            card.registerNewTrace(5, DateTime.Now.AddDays(-3), "Lorem ipsum 2");
            card.registerNewTrace(8, DateTime.Now.AddDays(-5), "Lorem ipsum 3");
            card.registerNewTrace(120, DateTime.Now.AddDays(-2), "Lorem ipsum 4");
            card.showCard();
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
            Owner = owner;
            Number = cardNumberSeed.ToString().PadLeft(9, '0');
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

        public void registerNewTrace(decimal kilometers, DateTime date, string note)
        {
            var trace = new Trace(kilometers, date, note);
            allTraces.Add(trace);
        }

        public void showAllTraces()
        {
            foreach (var trace in allTraces)
            {
                Console.WriteLine($"  {trace.Date.ToString("dd.MM.yyyy HH:mm")} -{trace.Kilometers,4}km {trace.Note}");
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
    }

    public class Trace
    {
        public decimal Kilometers { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public Trace(decimal kilometers, DateTime date, string note)
        {
            this.Kilometers = kilometers;
            this.Date = date;
            this.Note = note;
        }
    }
}
