using System;
using System.Collections.Generic;
using System.Text;

namespace Stealth_Airline
{
    class Order_Schedule
    {
        // schedule, and which orders
        public Schedule Schedule { get; private set; }
        public Order Orders { get; set; }

        public Order_Schedule(Schedule schedule, Order orders)
        {
            Schedule = schedule;
            Orders = orders;
        }

        public Order_Schedule( Order orders)
        {
            Schedule = null;
            Orders = orders;
        }

        public override string ToString()
        {   
            if (Schedule != null)
            {
                return $"order: {Orders.Code}, flightNumber: {Schedule.FlightNumber}, departure: {Schedule.Departure_City_Code.Id},  arrival: {Schedule.Arrival_City_Code.Id}, day: {Schedule.Day}";
            }
            else
            {
                return $"order: {Orders.Code}, flightNumber: not scheduled";
            }

        }
    }
}
