using System;

namespace _1050ITproject2
{
    class Program
    {
        static void Main(string[] args)
        {
            //John Doe 34 Spouse.Jane
            //Spouse.Doe Spouse.32 Spouse.Spouse.John
            Person p1 = new Person();
            p1.FirstName = "John"; p1.LastName = "Doe";
            p1.Age = 34;
            p1.Spouse = new Person();
            p1.Spouse.FirstName = "Jane";
            p1.Spouse.LastName = p1.LastName;
            p1.Spouse.Age = 32;
            p1.Spouse.Spouse = p1;

            //David Smith 76 Spouse.Dora
            //Spouse.Smith Spouse.64 Spouse.Spouse.John
            Person p2 = new Person(); 
            p2.FirstName = "David";
            p2.LastName = "Smith";
            p2.Age = 76;
            p2.Spouse = new Person();
            p2.Spouse.FirstName = "Dora";
            p2.Spouse.LastName = p2.LastName;
            p2.Spouse.Age = 64;
            p2.Spouse.Spouse = p2;

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            SumOfAllAges = p1.Age + p1.Spouse.Age + p2.Age + p2.Spouse.Age;
            Console.WriteLine(SumOfAllAges / 4);

        }
    }
}
