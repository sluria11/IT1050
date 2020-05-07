using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slurls
{
    public class Passenger
    {
        private static string Name;
        private static double Weight;

        public Passenger(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }
        public double GetWeight()
        {
            return Weight;
        }
    }
}
