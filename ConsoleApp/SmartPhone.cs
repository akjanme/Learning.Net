using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{                //Child    : Parent
                 //Derived  : Base
    public class SmartPhone : Mobile 
    { 
        public void TouchScreen()
        { 
            Console.WriteLine("touch is working.");
        }
        public void PagerText()
        {
            Pager();
        }
    }
}
