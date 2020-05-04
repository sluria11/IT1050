namespace Lab3
{
    public class Instructor
    {
        private string IName;
        private string CourseName;

        public Instructor(string iname, string instcoursname)
        {
            this.IName = iname;
            this.CourseName = instcoursname;
        }

        //Invoke Set Student Grade Method
        public void StudentGrade(Student stname, int grade)
        {
            stname.SetStudentGrade(grade);
        }

        //Print Instructor Information
        public void PrintInstructorInfo()
        {
            System.Console.WriteLine(this.IName + " teaches "+ this.CourseName + ".");
            System.Console.WriteLine();
         }

        //Return Instructor Information for Print Student Information
        public string PrintStInstructorInfo()
        {
            return "My " + this.CourseName + " Instructor is " + this.IName;
        }
    }
}
