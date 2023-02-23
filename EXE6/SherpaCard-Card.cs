using NeverSurrender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE6
{
    public class SherpaCard : Card
    {
        private string sherpaId = "1";
        public string SherpaId { get; }

        public SherpaCard(string owner, string sherpaId) : base(owner)
        {
            this.SherpaId = sherpaId;
        }
        public List<Trip> AllTrips = new List<Trip> {};
        public void RegisterNewTripWithGroup(string startTime, string endTime, int kilometers)
        {
            var trip = new Trip();
            AllTrips.Add(trip);

        }
    }
}