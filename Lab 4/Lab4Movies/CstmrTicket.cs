
namespace Lab4Movies
{
    public class CstmrTicket
    {
        public bool showTime;

        //Concessions quantities
        public int qsDrink;
        public int qlDrink;
        public int qhDog;
        public int qpCorn;
        public int qcandy;
        public double qconsTotal;

        //Movie ticket quantities
        public int cChild;
        public int cAdult;
        public int cSenior;
        public int totalPeople;

        //Costs
        public double ticketCost;
        public double consTotal;
        public double discount;

        public CstmrTicket()
        {
            //True is matinee, false is evening 
            this.showTime = Order.AskforShowtime();

            //Number of seniors attending
            this.cSenior = Order.AskForPerson("seniors");

            //Number of adults attending
            this.cAdult = Order.AskForPerson("adults");

            //Number of children attending
            this.cChild = Order.AskForPerson("children");
            System.Console.WriteLine();

            //Count number of people to be used for the discount
            this.totalPeople = this.cSenior + this.cAdult + this.cChild;
        }

        public void GetConcessionOrder()
        {
            System.Console.WriteLine("Please Place Your Concession Order...");
            this.qsSoda = Order.AskforInt("small drinks");
            this.qlSoda = Order.AskforInt("large drinks");
            this.qhDog = Order.AskforInt("hot dogs");
            this.qpCorn = Order.AskforInt("popcorn");
            this.qcandy = Order.AskforInt("candy");
        }

        //total concession cost
        public double calculateConcession()
        {
            consTotal = 0;
            consTotal += Pricing.csSoda * qsSoda;
            consTotal += Pricing.clSoda * qlSoda;
            consTotal += Pricing.chDog * qhDog;
            consTotal += Pricing.cpCorn * qpCorn;
            consTotal += Pricing.ccandy * qcandy;
            System.Console.WriteLine();
            System.Console.WriteLine("Your Concession total is $" + consTotal);
            return consTotal;
        }

        //total discount
        public double calculateDiscount()
        {
            discount = 0;
            if (this.totalPeople > 0)
            {
                if (this.qpCorn > 0 && this.qlSoda > 0)
                {
                    if (this.qpCorn >= this.qlSoda && this.qlSoda <= this.totalPeople)
                    {
                        discount += 2 * qlSoda;
                    }
                    else if (this.qpCorn >= this.qlSoda && this.qlSoda >= this.totalPeople)
                    {
                        discount += 2 * this.totalPeople;
                    }
                    else if (this.qpCorn < this.qlSoda && this.qpCorn <= this.totalPeople)
                    {
                        discount += 2 * qpCorn;
                    }
                    else if (this.qpCorn < this.qlSoda && this.qpCorn >= this.totalPeople)
                    {
                        discount += 2 * this.totalPeople;
                    }
                }
            }

            if (this.showTime == false && this.totalPeople > 2)
            {
                System.Console.WriteLine("Please may have a free popcorn!");
            }

            if (qcandy > 3)
            {
                int x = qcandy / 3;
                System.Console.WriteLine("Please may have " + x + " free candy!");
            }
            System.Console.WriteLine("Your discount is $" + discount);
            return discount;
        }

        //total ticket cost
        public double calculateTicket()
        {
            if (this.showTime == true)
            {
                ticketCost = 0;
                ticketCost += this.cSenior * Pricing.mSenior;
                ticketCost += this.cAdult * Pricing.mAdult;
                ticketCost += this.cChild * Pricing.mChild;
                System.Console.WriteLine("Your Movie Tickets will Cost $" + ticketCost);
                System.Console.WriteLine();
                return ticketCost;
            }
            else
            {
                ticketCost = 0;
                ticketCost += cSenior * Pricing.eSenior;
                ticketCost += cAdult * Pricing.eAdult;
                ticketCost += cChild * Pricing.eChild;
                System.Console.WriteLine("Your Tickets will Cost $" + ticketCost);
                System.Console.WriteLine();

                return ticketCost;
            }
        }
    }
}
