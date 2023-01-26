using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        { }
        public class Date
        {
            private int _month = 7;  // Backing store

            public int Month
            {
                get => _month;
                set
                {
                    if ((value > 0) && (value < 13))
                    {
                        _month = value;
                    }
                }
            }
        }
    }
}
