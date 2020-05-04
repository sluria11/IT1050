namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            John.StudentGrade(Jane, 95);
            John.StudentGrade(Joe, 85);
            Mike.StudentGrade(Melissa, 90);
            Mike.StudentGrade(Matt, 92);


            John.PrintInstructorInfo();
            Mike.PrintInstructorInfo();

      
            Jane.PrintStudentInfo();
            Joe.PrintStudentInfo();
            Melissa.PrintStudentInfo();
            Matt.PrintStudentInfo();

            System.Console.ReadKey();

        }
    }
}