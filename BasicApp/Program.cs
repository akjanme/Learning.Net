using System;

namespace BasicApp
{
    public class Program
    {  
        static void Main(string[] args)
        {
            //HelloWorld();
            //ReadWrite();

            //Basic1 basic1 = new Basic1();
            //basic1.StringOperation();

            MethodCalling methodCalling = new MethodCalling(); 
            int a = 10;
            //Console.WriteLine(a);
            //methodCalling.ShowResult(a);//call by value
            //Console.WriteLine(a);

            int c =1;
            methodCalling.ShowResult(ref c);//call by reference
            Console.WriteLine(c);


            int b;
            int result = methodCalling.Square(a,out b);
            Console.WriteLine(result);

            Console.WriteLine(b);

            //MethodCalling.PrintResult();

            Console.ReadKey();
        }

         /// <summary>
         /// this method will be printing hello world
         /// </summary>
        static void HelloWorld()
        { 
            //this will print hello world
            Console.WriteLine("Hello World!");
        }
        static void ReadWrite()
        {
            const string name = "MyApp";  

            Console.WriteLine(name);
        }
    }
}
