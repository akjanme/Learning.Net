using System;
using System.Collections.Generic;

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

            //MethodCalling methodCalling = new MethodCalling(); 
            //int a = 10;
            //Console.WriteLine(a);
            //methodCalling.ShowResult(a);//call by value
            //Console.WriteLine(a);

            //int c =1;
            //methodCalling.ShowResult(ref c);//call by reference
            //Console.WriteLine(c);


            //int b;
            //int result = methodCalling.Square(a,out b);
            //Console.WriteLine(result);

            // Console.WriteLine(b);

            //MethodCalling.PrintResult();


            //var list = SetListData();
            //foreach (var l in list)
            //{
            //    Console.WriteLine(l);
            //}
            //for (int i=0;i<list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //var list = new Basic1().GetDictionary();
            //foreach (var s in list)
            //{
            //    Console.WriteLine(s.Key + ":" + s.Value);
            //} 
            ExceptionHandling exceptionHandling = new ExceptionHandling();

            int result= exceptionHandling.Divide(1, 0);
            Console.WriteLine(result);
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

        static void ArrayOperations(int[] arr)
        {
            foreach (int ar in arr)
            {
                int a = ar;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i];
                arr[i] = i;
            }
        }
        static List<string> SetListData()
        {
            List<string> names = new List<string>();
            names.Add("Ramesh");
            names.Add("Suresh");
            names.Add("Manish");
            names.Add("Mohan");
            return names;
        }
    }
}
