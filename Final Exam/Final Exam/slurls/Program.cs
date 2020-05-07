using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slurls
{
    public class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Passenger passenger = new Passenger("A1", 180);
            elevator1.AddOccupant(passenger, 0);
            passenger = new Passenger("A2", 220);
            elevator1.AddOccupant(passenger, 1);
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = new Elevator(3, 600);
            passenger = new Passenger("A1", 200);
            elevator2.AddOccupant(passenger, 0);
            passenger = new Passenger("A2", 200);
            elevator2.AddOccupant(passenger, 1);
            passenger = new Passenger("A3", 201);
            elevator2.AddOccupant(passenger, 2);
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
        }
    }
}
