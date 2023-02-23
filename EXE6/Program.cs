using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NeverSurrender
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card("Arkadiusz");
            card.RegisterNewTrace(42, " 22.02.2023", "Test Kropki");
            card.ShowCard();
            Console.ReadKey();
        }
    }
    class Card
    {
        private int number = 1;
        public string Owner { get; set; }
        public string Number { get; }
        public Card(string owner)
        {
            Owner = owner;
            Number = number.ToString().PadLeft(9, '0');
            number++;
        }
        public void ShowCard()
        {
            Console.WriteLine($"Właściciel legitymacji: {Owner} o numerze legitymacji: {Number}");
            ShowAllTraces();
            Console.WriteLine($"Łączny dystans to: {Distance}km");
        }
        private List<Trace> allTraces = new List<Trace>{};
        public void RegisterNewTrace(double kilometers, string date, string notes)
        {
            var trace = new Trace(kilometers, date, notes);
            allTraces.Add(trace);
        }
        public string ShowAllTraces()
        {
            foreach (var elem in allTraces)
            {
                Console.WriteLine(elem.Kilometers + elem.Date + elem.Notes);
            }
            return allTraces.ToString();
        }
        public double Distance
        {
            get{
                double distance = 0;
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
        private double kilometers;
        private string date;
        private string notes;
        public double Kilometers { get; set; }
        public string Date { get; set; }
        public string Notes { get; set; }
        public Trace(double kilometers, string date, string notes)
        {
            Kilometers = kilometers;
            Date = date;
            Notes = notes;
        }
    }
}
