using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Plan
{
    internal class CityNode
    {
        public string cityName;  // Stores the name of the city
        public CityNode next;    // Points to the next city in the itinerary

        // Constructor to create the CityNode. Pass the name of the city as parameter.
        public CityNode(string name)
        {
            cityName = name;
            next = null;
        }
    }
}
