using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp
{
    public class MethodCalling
    {
        public void ShowResult(int a)
        {
            a = a * a;
            Console.WriteLine(a);
        }
        public void ShowResult(ref int p)
        {
            p = p + p;
            Console.WriteLine(p);
        }
        public static void PrintResult()
        {
            Console.WriteLine("Static Hello");
        }
        public int Square(int p,out int b)
        {
            b = p+10;
            return p * p;
        }
    }

}
