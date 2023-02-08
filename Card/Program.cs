﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card = new Card("Arkadiusz");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.");
        }
        public class Card
        {
            private static int cardNumberSeed = 1234567890;




            public string Number { get; }
            public string Owner { get; set; }

            public void RegisterNewTrace(decimal kilometers, DateTime date, string note)
            {

            }
            public Card(string owner)
            {
                this.Owner = owner;
                this.Number = cardNumberSeed.ToString();
                cardNumberSeed++;
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

                    return distance;
                }
            }
        }
        private List<Trace> allTraces = new List<Trace>;
        public class Trace
        {
            public decimal Kilometers { get; }
            public DateTime Date { get; }
            public string Notes { get; }


            public Trace(decimal kilometers, DateTime date, string note)
            {
                this.Kilometers = kilometers;
                this.Date = date;
                this.Notes = note;
            }
        }
    }
}