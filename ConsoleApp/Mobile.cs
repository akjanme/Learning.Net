using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Mobile  
    {
        public void Calling()
        {
            Console.WriteLine("You call is getting connected");
        }
        public void SMS()
        {

            Console.WriteLine("text message sent.");
        }
        protected void Pager()
        { 
            Console.WriteLine("Pager message sent.");
        }
    }
} 