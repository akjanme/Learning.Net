using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Animal  // Base class (parent) 
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound");
        } 
    }

    public class Peacock : Animal  // Derived class (child) 
    {
        public override void Speak()
        {
            Console.WriteLine("The Peacock says: piu piu piu");
        }
        public void Color(string color1, string color2)
        {
            Console.WriteLine("The color is " + color1 +" & "+ color2);
        }
        public void Color(string color1)
        {
            Console.WriteLine("The color is " + color1);
        }
    }

    public class Koyal : Animal  // Derived class (child) 
    {
        public override void Speak()
        {
            Console.WriteLine("The koyal says: koohu koohu ");
        } 
    }

}
