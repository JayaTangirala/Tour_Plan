using System.Collections.Generic;
using System.Xml.Linq;
using System;
using Tour_Plan;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create nodes for the cities in the proposed order: London → Oxford → Birmingham → Manchester.
        Tour itinerary = new Tour();
        itinerary.insertLast("London");
        itinerary.insertLast("Oxford");
        itinerary.insertLast("Birmingham");
        itinerary.insertLast("Manchester");

        Console.Out.WriteLine("Original planned tour: ");
        itinerary.display();

        //update itenary
        itinerary.removeCity("Birmingham");
        itinerary.insertLast("York");
        Console.Out.WriteLine("Updated tour: ");
        itinerary.display();
    }
}