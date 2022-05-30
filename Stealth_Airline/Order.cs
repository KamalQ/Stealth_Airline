using System;
using System.Collections.Generic;
using System.Text;

namespace Stealth_Airline
{
    class Order
    {
        public string Code { get; set; }
        public Airport Destination_City_Code { get; set; }
        public Schedule Schedule { get; set; }

    }
}
