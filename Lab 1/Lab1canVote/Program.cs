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

            // +==================================================================================+
            // | start collecting the data.                                                       |
            // +==================================================================================+

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            fullName = (firstName + " " + middleInitial + ". " + lastName);

            System.Console.Write("How tall are you? Feet only 4, 5, 6, 7? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond " + heightFeet + " feet tall are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("True or False.  Are you a U.S. citizen? ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = (age >= 18) && isCitizen;

            // +==================================================================================+
            // | Write the information to the screen.   R3                                        |
            // +==================================================================================+

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Name: "+(fullName));
            System.Console.WriteLine();
            System.Console.Write("Height: "+(totalHeightCM +" centimeters"));
            System.Console.WriteLine();
            System.Console.Write("Are you eligible to vote? " + canVote);
            System.Console.WriteLine();
            System.Console.Write("Select any key to end.");
            System.Console.ReadKey();
            }
    }
}
