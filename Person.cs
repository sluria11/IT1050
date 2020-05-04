using System;
namespace _1050ITproject2
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.LastName + ", " + this.FirstName;
        }

        public string PrintNameAndAge()
        {
            GetFullName() + " (" + this.Age + ")";
        }

        
        //(p1.Age + p2.Spouse.Age + p2.Age + p2.Spouse.Age) / 4 = 51.5

    }
}
