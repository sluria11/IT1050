using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slurls
{
    public class Elevator
    {
        private static double MaxWeight;
        private static Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double sum = 0;
            for (int i = 0; i < Occupants.Length; i++)
            {
                sum = sum + Occupants[i].GetWeight();
            }
            return sum;
        }
        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
