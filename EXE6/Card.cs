using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE6
{
    public class Card
    {
        private int number = 1;
        private string owner = "Kropka";

        public string Number { get; set; }
        public string Owner { get; set; }

        public Card()
        {
            this.Owner = owner;
            this.Number = number.ToString().PadLeft(9, '0');
            number++;
        }
        public List<Trace> allTraces = new List<Trace> { };

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
}