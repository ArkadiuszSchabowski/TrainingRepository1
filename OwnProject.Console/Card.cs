using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnProject.Console
{
    class Card
    {
        private static int cardNumberSeed = 1234567890;
        public string Number { get; }

        public Card()
        {
            this.Number = cardNumberSeed.ToString();
        }
    }
}