using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stealth_Airline
{   

    class Order_List : IOrder_List
    {

        public Airport temp_city_code { get; set; }

        public IList<Order> GetOrders(string path_to_file)
        {
            var Order = new List<Order>();
            string jsonString = File_Reader.ReadAllText(path_to_file);
            dynamic listed_json = JObject.Parse(jsonString);

            foreach (var each in listed_json)
            {

                if ((each.Value["destination"]) == "YUL")
                {
                    temp_city_code = Airport.YUL;
                }
                else if ((each.Value["destination"]) == "YYZ")
                {
                    temp_city_code = Airport.YYZ;
                }
                else if ((each.Value["destination"]) == "YYC")
                {
                    temp_city_code = Airport.YYC;
                }
                else if ((each.Value["destination"]) == "YVR")
                {
                    temp_city_code = Airport.YVR;
                }

                Order.Add(new Order { Code = each.Name, Destination_City_Code = temp_city_code });
            }

            //var orders = JsonConvert.DeserializeObject<Dictionary<string, Order>>(jsonString).Select(p => new Order { Code = p.Key, Destination_City_Code = p.Value.Destination_City_Code }).ToList();

            return Order;
        }
    }
}
