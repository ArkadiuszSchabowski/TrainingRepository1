using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE6
{
    public class Trip
    {
        public string StartTime;
        public string EndTime;
        public int Kilometers;
        public Trip(string startTime, string endTime, int kilometers)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Kilometers = kilometers;
        }
    }
}