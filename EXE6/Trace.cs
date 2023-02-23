using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE6
{
    public class Trace
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