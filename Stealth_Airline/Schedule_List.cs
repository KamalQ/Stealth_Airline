using System;
using System.Collections.Generic;
using System.Text;

namespace Stealth_Airline
{
    class Schedule_List : ISchedule_List
    {
        public IList<Schedule> GetSchedules()
        {
            var schedules = new List<Schedule>();

            schedules.Add(new Schedule { FlightNumber = 1, Departure_City_Code = Airport.YUL, Arrival_City_Code = Airport.YYZ, Day = 1, Max_Capacity = 20, Is_Full_Capacity = false });
            schedules.Add(new Schedule { FlightNumber = 2, Departure_City_Code = Airport.YUL, Arrival_City_Code = Airport.YYC, Day = 1, Max_Capacity = 20, Is_Full_Capacity = false });
            schedules.Add(new Schedule { FlightNumber = 3, Departure_City_Code = Airport.YUL, Arrival_City_Code = Airport.YVR, Day = 1, Max_Capacity = 20, Is_Full_Capacity = false });

            schedules.Add(new Schedule { FlightNumber = 4, Departure_City_Code = Airport.YUL, Arrival_City_Code = Airport.YYZ, Day = 2, Max_Capacity = 20, Is_Full_Capacity = false });
            schedules.Add(new Schedule { FlightNumber = 5, Departure_City_Code = Airport.YUL, Arrival_City_Code = Airport.YYC, Day = 2, Max_Capacity = 20, Is_Full_Capacity = false });
            schedules.Add(new Schedule { FlightNumber = 6, Departure_City_Code = Airport.YUL, Arrival_City_Code = Airport.YVR, Day = 2, Max_Capacity = 20, Is_Full_Capacity = false });

            return schedules;
        }
    }
}
