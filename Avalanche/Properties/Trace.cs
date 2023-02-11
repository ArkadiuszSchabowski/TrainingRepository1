﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalanche.Properties
{
    public class Trace
    {
        public decimal Kilometers { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Trace(decimal kilometers, string note)
        {
            this.Kilometers = kilometers;
            this.Notes = note;
        }
    }
}