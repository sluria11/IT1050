namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;              
            bool q = true;      

            
            Company c1 = new Company();
            c = c1.getCompanyInfo();         
            System.Console.WriteLine();

            Employees[] arrayofEmployees;
            arrayofEmployees = new Employees
                [c];

            
            while (q == true)
            {

                for (int i = 0; i < c; i++)
                {
                    arrayofEmployees[i] = new Employees();
                    System.Console.Write("Employee Name: ");
                    arrayofEmployees[i].eName = System.Console.ReadLine();

                    System.Console.Write("Employee Number: ");
                    arrayofEmployees[i].eNumber = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine();
                }
                System.Console.Write("True or False:  Would you like to reenter the employee information? ");
                q = bool.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
            }

            
            c1.printCompanyInfo();
            System.Console.WriteLine();

            
            for (int i = 0; i < c; i++)
            {
                System.Console.Write("Employee Name: " + arrayofEmployees[i].eName + ", ");
                System.Console.WriteLine("Employee Badge Number: " + arrayofEmployees[i].eNumber);
            }

            System.Console.Write("Press any key to complete...");
            System.Console.ReadKey();

        }
    }
}