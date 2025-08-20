using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tour_Plan
{
    internal class Tour
    {
        public CityNode head;
        public Tour()
        {
            head = null;
        }
        public void insertLast(string city)
        {
            CityNode newCityNode = new CityNode(city); //creates a node with the cityName as city given in parameter
            if (head == null) //list is empty for the first time.
                head = newCityNode; //make the newly created CityNode as head.
            else //if the list is not empty, there is a list with some cities already. Traverse to the end of the list starting from head and add the newCityNode at last.
            {
                CityNode temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newCityNode;
            }
        }
        public void removeCity(string city)
        {
            CityNode pointer = head;
            CityNode prevPointer = head;
            if (head == null)
                Console.WriteLine("City doesnt exists");
            else
            {
                while (pointer.cityName != city)
                {
                    prevPointer = pointer;
                    pointer = pointer.next;
                }
                prevPointer.next = pointer.next;
                pointer = null;
            }
        }
        public void display()
        {
            CityNode pointer = head;
            if (pointer == null)
            {
                Console.WriteLine("List empty \n");
                return;
            }

            while (pointer != null)
            {
                Console.Write(pointer.cityName + "----> ");
                pointer = pointer.next;
            }
            Console.WriteLine("Null\n");
        }
    }
}
