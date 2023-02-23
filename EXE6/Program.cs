using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace NeverSurrender
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.RegisterNewTrace(5, "22.02.2023", "Kropka przygotowanie do zdobycia tytułu mistrza C#");
            card.RegisterNewTrace(42, "23.02.2023", "Kropka Mistrzem C#");
            card.ShowCard();
            Console.ReadKey();
        }
    }
    class Card
    {
        private int number = 1;
        private string owner = "Kropka";

        public string Number { get; set; }
        public string Owner { get; set; }

        public Card()
        {
            this.Owner = owner;
            this.Number = number.ToString().PadLeft(9, '0');
        }
        public List<Trace> allTraces = new List<Trace> {};

        public void ShowCard()
        {
            Console.WriteLine($"Wlasciciel legitymacji to: {Owner}, numer legitymacji to {Number}.\n");
            ShowAllTraces();
            Console.WriteLine($"\nTwój przebyty dystans to: {Distance}km");

        }
        public void ShowAllTraces()
        {
            foreach (var trace in allTraces)
            {
                Console.WriteLine($"{trace.Kilometers}, {trace.Date}, {trace.Notes}.");
            }
        }
        public void RegisterNewTrace(double kilometers, string date, string notes)
        {
            var trace = new Trace(kilometers, date, notes);
            allTraces.Add(trace);
        }
        public double Distance
        {
           get
            {
                double distance = 0;
                foreach (var trace in allTraces)
                {
                    distance += trace.Kilometers;
                }
                return distance;
            }
        }
    }
    class Trace
    {
        public double Kilometers { get; }
        public string Date { get; }
        public string Notes { get; }

        public Trace(double kilometers, string date, string notes)
        {
            this.Kilometers = kilometers;
            this.Date = date;
            this.Notes = notes;
        }
    }
}