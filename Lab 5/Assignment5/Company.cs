namespace Assignment5
{
    class Company
    {
        public string cName;
        public int stNumber;
        public int totalEmployees;

        
        public int getCompanyInfo()
        {
            System.Console.Write("What is the name of your Company: ");
            cName = System.Console.ReadLine();
            System.Console.Write("What is the street number: ");
            stNumber = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many employees are there: ");
            totalEmployees = int.Parse(System.Console.ReadLine());
            return totalEmployees;
        }

        public void printCompanyInfo()
        {
            System.Console.WriteLine("Company Name:  " + cName);
            System.Console.WriteLine("Street Number:  " + stNumber);
            System.Console.WriteLine("Total number of employees:  " + totalEmployees);
        }
    }
}