using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Class_A
    {
        public Class_A(int a, int b)
        {
            A = a;
            B = b;
        }
        public string Name = "Class A";
        private int A { get; set; }
        private int B { get; set; }

        public void Total()
        {
            Console.WriteLine("Total of 2 variables is {0}", A + B);
        }
    }
}
