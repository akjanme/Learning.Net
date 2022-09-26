using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Employee
    {
        public Employee(string name,int agep)
        {
            Name = name;
            Age = agep;
            Console.WriteLine("Object created");
        }
        string Name { get; set; } 

        private int age;
        public int Age
        {
            get { return age; }
            set {
                age = value;
                if (age > 60)
                    IsRetired = true;
                else
                    IsRetired = false;
            }
        }


        public bool IsRetired { get; set; }
    }
}