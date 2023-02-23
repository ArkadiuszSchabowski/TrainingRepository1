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
        private int sherpaId = 1;
        public string SherpaId { get; set; }

        public SherpaCard()
        {
            SherpaId = sherpaId.ToString().PadLeft(4,'0');
        }
        public List<Trip> AllTrips = new List<Trip> {};

        public void RegisterNewTripWithGroup(string startTime, string endTime, int kilometers)
        {
            var trip = new Trip(startTime, endTime, kilometers);
            AllTrips.Add(trip);
        }
        public void ShowSherpaCard()
        {
            Console.WriteLine($"\nNumer Legitymacji Twojego Sherpy: {SherpaId}");
        }
        public void ShowAllPlannedTrips()
        {
            foreach (var trip in AllTrips)
            {
                Console.WriteLine($"{trip.StartTime}, {trip.EndTime}, {trip.Kilometers}");
            }
        }
    }
}