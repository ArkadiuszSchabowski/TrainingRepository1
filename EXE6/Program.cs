using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NeverSurrender
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.RegisterNewTrace(10, "", "Lorem ipsum 1");
            card.RegisterNewTrace(5, "", "Lorem ipsum 2");
            card.RegisterNewTrace(8, "", "Lorem ipsum 3");
            card.RegisterNewTrace(120, "", "Lorem ipsum 4");
            card.ShowCard();
            Console.ReadKey();
        }
    }
    class Card
    {
        private int numer = 1;
        private string wlasciciel = "Kropka";

        public string Numer { get; set; }
        public string Wlasciciel { get; set; }

        public Card()
        {
            Numer = numer.ToString().PadLeft(9, '0');
            Wlasciciel = wlasciciel;
        }
        public void ShowCard()
        {
            Console.WriteLine($"Właściciel legitymacji to {Wlasciciel}, numer legitymacji to {Numer}\n");
            showAllTraces();
            Console.WriteLine($"\n  Pokonany dystans: {Distance}km");

        }
        private List<Trace> allTraces = new List<Trace> { };

        public void RegisterNewTrace(decimal kilometers, string date, string notes)
        {
            var trace = new Trace(kilometers, date, notes);
            allTraces.Add(trace);
        }
        public void showAllTraces()
        {
            foreach (var trace in allTraces)
            {
                Console.WriteLine($"{trace.Date} {trace.Kilometers,4}km {trace.Notes}");
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
        public string Date { get; }
        public string Notes { get; }
        public Trace(decimal kilometers, string date, string notes)
        {
            Kilometers = kilometers;
            Date = date;
            Notes = notes;
        }
    }
    
}