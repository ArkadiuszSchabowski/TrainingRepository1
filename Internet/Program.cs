using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet
{
    class players
    {
        public string playerName { get; set; }
        public string playerCountry { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<players> myListOfPlayers = new List<players>();

            foreach (var player in myListOfPlayers)
            {
                Console.WriteLine("1");
                Console.ReadKey();
            }
        }
    }
}