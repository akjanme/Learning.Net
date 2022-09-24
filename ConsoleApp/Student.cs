namespace ConsoleApp
{
    public class Student
    { 
        public Student(string fname, string lname,int marks)
        {
            FirstName = fname;
            LastName = lname;
            Marks = marks;
        }  
        private int ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public string Name
        {
            get { return FirstName + " " + LastName; }
        }
        public string Result { get; set; }
        private int marks;
        private int Marks
        {
            get { return marks; }
            set {
                marks = value;
                if (marks > 33)
                {
                    Result = "Pass";
                }
                else
                {
                    Result = "Fail";
                }
            }
        } 
    }
}
