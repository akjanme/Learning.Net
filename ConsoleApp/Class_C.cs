using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Class_C : Class_B
    {
        public string Name = "Class c";
        public Class_C(int a, int b) : base(a, b)
        {
            A = a;
            B = b;
        }
        private int A { get; set; }
        private int B { get; set; }

        public void Subtract()
        {
            Console.WriteLine("Subtract of 2 variables is {0}", A - B);
        }
    }
}
