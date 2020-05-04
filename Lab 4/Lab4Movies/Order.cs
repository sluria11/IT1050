namespace Lab4Movies
{
    class Order
    {
        public static bool AskforShowtime()
        {
            System.Console.Write("True or False.  Are you attending the matinee? ");
            return bool.Parse(System.Console.ReadLine());
        }

        public static int AskForPerson(string person)
        {
            System.Console.Write("How many " + person + " are attending? ");
            return int.Parse(System.Console.ReadLine());
        }

        public static int AskforInt(string item)
        {
            System.Console.Write("How many " + item + " would you like? ");
            return int.Parse(System.Console.ReadLine());
        }
    }
}