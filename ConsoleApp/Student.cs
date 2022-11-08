namespace ConsoleApp
{
    public class Student
    {
        public Student()
        {
            firstname = "";
            lastname = "";
            Age = 0;
        }
        public Student(string p_firstname,string p_lastname,int p_age) //Constructor
        {
            firstname = p_firstname;
            lastname = p_lastname;
            Age = p_age;
        }
        private string firstname;
        private string lastname;

        public string Name
        {
            get { return firstname + " " + lastname; }
        }
        private string fatherName;
        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }
        private int Age { get; set; }

        public bool IsMinor
        {
            get
            {
                if (Age >= 18)
                    return false;
                else return true;
            }
        }
        public string IsAdult()
        {
            if (Age >= 18)
            {
                return "Student is Adult";
            }
            else
            {
                return "Student is Minor";
            }
        }
    }
}
