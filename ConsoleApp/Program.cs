using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Class_A class_A = new Class_A(10, 5);
            //class_A.Total();

            Class_C class_c = new Class_C(10, 5);
            class_c.Total();
            class_c.Multiply();
            class_c.Subtract();

            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Calling();
            smartPhone.TouchScreen(); 

            Console.ReadKey();
        }
    }

}
