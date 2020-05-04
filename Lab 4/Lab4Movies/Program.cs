namespace Lab4Movies
{
    class Program
    {
        static void Main(string[] args)
        {   
            double totalCost=0;

            System.Console.WriteLine("Welcome. How may I help you? ");

            //Create Customer Ticket
            CstmrTicket c1 = new CstmrTicket();

            //Concession Order
            c1.GetConcessionOrder();

            //Calculate Concession Order
            totalCost += c1.calculateConcession();

            //Calculate Discount
            totalCost -= c1.calculateDiscount();

            //Calculate Customer Ticket Sales
            totalCost += c1.calculateTicket();
            System.Console.WriteLine("Your Total is $" + totalCost);
            System.Console.Write("Press any key to finish");
            System.Console.ReadKey();
        }
    }
}