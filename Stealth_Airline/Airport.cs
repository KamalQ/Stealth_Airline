using System;
using System.Collections.Generic;
using System.Text;

namespace Stealth_Airline
{
    class Airport
    {
        private string v;

        public Airport() { }

        public Airport(string name)
        {
            this.Id = name;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public string Province { get; private set; }
        public string Country { get; private set; }
        public TimeZoneInfo TimeZone { get; private set; }

        public override string ToString() => $"{Name} ({Id}), {City}, {Province}, {Country}, {TimeZone.DisplayName}";

        public static Airport YUL => new Airport
        {
            Id = "YUL",
            Name = "Montréal-Pierre Elliott Trudeau International Airport",
            City = "Montreal",
            Province = "Quebec",
            Country = "Canada",
            TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
        };

        public static Airport YYZ => new Airport
        {
            Id = "YYZ",
            Name = "Toronto Pearson International Airport",
            City = "Toronto",
            Province = "Ontario",
            Country = "Canada",
            TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
        };

        public static Airport YYC => new Airport
        {
            Id = "YYC",
            Name = "Calgary International Airport",
            City = "Calgary",
            Province = "Alberta",
            Country = "Canada",
            TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time")
        };

        public static Airport YVR => new Airport
        {
            Id = "YVR",
            Name = "Vancouver International Airport",
            City = "Vancouver",
            Province = "British Columbia",
            Country = "Canada",
            TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
        };

    }
}
