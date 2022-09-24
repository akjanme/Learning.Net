using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ramesh","Sharma",60);            
            Console.WriteLine(student.Name);  
            Console.WriteLine(student.Result); 
            Console.ReadKey(); 
        }
    }

}
