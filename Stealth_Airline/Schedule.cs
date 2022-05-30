using System;
using System.Collections.Generic;
using System.Text;

namespace Stealth_Airline
{
    class Schedule
    {
        // Schedule of flights and info
        public int FlightNumber { get; set; }
        public Airport Departure_City_Code { get; set; }
        public Airport Arrival_City_Code { get; set; }
        public int Day { get; set; }
        public int Max_Capacity { get; set; }
        public int Current_Capacity { get; set; } = 0;
        public bool Is_Full_Capacity { get; set; }

        public override string ToString()
        {
            return $"Flight: {FlightNumber}, departure: {Departure_City_Code.Id},  arrival: {Arrival_City_Code.Id}, day: {Day}";
        }
    }
}
