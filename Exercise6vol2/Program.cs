using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6vol2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var card = new Card("Arkadiusz");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.");
            Console.WriteLine($"Przedstawiam Twoje wszystkie trasy: {card.AllTraces}");
            Console.ReadKey();
        }
    }
    public class Card
    {
        private static int cardNumberSeed = 1234567890;
        public Card(string owner)
        {
            this.Owner = owner;
            this.Number = cardNumberSeed.ToString();
            cardNumberSeed++;
            this.AllTraces = allTraces.ToString();
        }
        private List<Trace> allTraces = new List<Trace> ();
        Trace FirstTrip = new Trace(10, "02.21.20", "Było ciężko");
        Trace SecondTrip = new Trace(20, "02.22.21", "Podczas wycieczki padał śnieg");

    public string Number { get; }
        public string Owner { get; set; }
        public string AllTraces { get; }
        public void RegisterNewTrace(decimal kilometers, string date, string note)
        {
            var trace = new Trace(kilometers, date, note);
            allTraces.Add(trace);
        }
        public string GetAccountHistory()
        {
            foreach (var elem in allTraces)
            {
                Console.WriteLine(elem);
                Console.ReadKey();
            }
            return allTraces.ToString(); 
        }
        public decimal Distance
        {
            get
            {
                decimal distance = 0;
                foreach (var item in allTraces)
                {
                    distance += item.Kilometers;
                }
                Console.WriteLine(distance);
                return distance;
            }
        }
    }
    public class Trace
    {
        public decimal Kilometers { get; }
        public string Date { get; }
        public string Notes { get; }
        public Trace(decimal kilometers, string date, string note)
        {
            this.Kilometers = kilometers;
            this.Date = date;
            this.Notes = note;
        }
    }
}