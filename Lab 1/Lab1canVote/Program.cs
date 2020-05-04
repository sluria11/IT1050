namespace Lab1canVote
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            

            System.Console.Write("First Name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Middle Initial: ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("Last Name: ");
            lastName = System.Console.ReadLine();

            fullName = (firstName + " " + middleInitial + ". " + lastName);

            System.Console.Write("Height in Feet:  ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Additional Height in Inches: ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            System.Console.Write("Age: ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("True or False.  Are you a U.S. citizen? ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = (age >= 18) && isCitizen;

            
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Name: "+(fullName));
            System.Console.WriteLine();
            System.Console.Write("Height: "+(totalHeightCM +" centimeters"));
            System.Console.WriteLine();
            System.Console.Write("Are you eligible to vote? " + canVote);
            System.Console.WriteLine();
            System.Console.Write("Press any key to end");
            System.Console.ReadKey();
            }
    }
}
