using System;
using System.Collections.Generic;
using System.Text;

namespace Stealth_Airline
{
    interface IOrder_List
    {
        IList<Order> GetOrders(string path_to_file);
    }
}
