using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicApp
{
    public class Basic1
    {
        public void StringOperation()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" }; 
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Volvo");
            arrayList.Add(true); 
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            } 
            foreach (var i in cars)
            {
                Console.WriteLine(i);
            }
        }

        public Dictionary<int, string> GetDictionary()
        {
            var dict = new Dictionary<int, string>
            {
                { 1, "Ram" },
                { 2, "Shyam" },
                { 3, "Kishor" }
            };
            return dict;
        }
    }
}
