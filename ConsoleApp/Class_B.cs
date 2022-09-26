using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{                //Child    //Parent
                 //Derived  //Base
    public class Class_B : Class_A
    {
        public Class_B(int a, int b) : base(a, b)
        {
            A = a;
            B = b;
        }
        public string Name = "Class B";
        private int A { get; set; }
        private int B { get; set; }

        public void Multiply()
        {
            Console.WriteLine("Multiplication of 2 variables is {0}", A * B);
        }

    }
}
