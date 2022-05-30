using System;
using System.Collections.Generic;
using System.Linq;

namespace Stealth_Airline
{
    class Program
    {
        public static IList<Schedule> Schedules { get; private set; }
        public static IList<Order> Orders { get; private set; }

        static void Main(string[] args)
        {

            // User Story 1
            Schedules = new Schedule_List().GetSchedules();

            foreach (var item in Schedules)
            {
                Console.WriteLine(item);
            }


            // User Story 2
            string file_path = @"C:\Users\Kamal\source\repos\Stealth_Airline\Stealth_Airline\JSON_Files\coding-assigment-orders.json";
            Orders = new Order_List().GetOrders(file_path);
            var order_schedule = new List<Order_Schedule>();

            foreach (var each_order in Orders)
            {
                bool was_added = false;

                foreach (var temp_schedule in Schedules)
                {
                    
                    if (temp_schedule.Arrival_City_Code.Id == each_order.Destination_City_Code.Id && temp_schedule.Is_Full_Capacity != true)
                    {
                        order_schedule.Add(new Order_Schedule(temp_schedule, each_order));
                        temp_schedule.Current_Capacity += 1;

                        if (temp_schedule.Current_Capacity == temp_schedule.Max_Capacity)
                        {
                            temp_schedule.Is_Full_Capacity = true;
                        }

                        was_added = true;
                    }

                }

                if (was_added == false)
                {
                    order_schedule.Add(new Order_Schedule(each_order));
                }

            }

            foreach (var temp_order in order_schedule)
            {
                Console.WriteLine(temp_order.ToString());
            }


        }
    }
}
