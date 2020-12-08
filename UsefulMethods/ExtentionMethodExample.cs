using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace UsefulMethods
{
    internal class ExtentionMethodExample
    {
        internal void SayWelcome()
        {
            var d = new Data();
            var data = d.GetData();

            //Example 1
            var person1 = data.FirstOrDefault(x =>x.Name=="Samir");
            person1.SayWelcome();  //Extension method pop up like linq method for example where and select and so on

            //Example 2
            var person2 = data.FirstOrDefault(x => x.Name == "David");
            person2.SayHello(person1);

            //Example 3
            var dt = data.ToArray();
            dt.DisplayEmployeeList();

            //Example 4
            data.GetAverageSalay();
        }

    }
    public static class Extensions 
    {
        public static void SayWelcome(this Data data) //must have this keyword on the first type, 
        {
            Console.WriteLine($"Welcome {data.Name}");
            //output: Welcome Samir
        }
        public static void SayHello(this Data data1, Data data2)    //no need to say this on second parameter, the second parameter should be passed 
        {
            Console.WriteLine($"{data1.Name} says hello to {data2.Name}");
            //output: David says hello to Samir
        }

        public static void DisplayEmployeeList(this Data[] data) //this method appears on an array of Data object
        {
            foreach (var item in data)
            {
                Console.WriteLine(item.Name); // output: Samir David Hanna Jan Mike ... 
            }
        }

        public static void GetAverageSalay(this List<Data> data)
        {
            var count = data.Count();
            int totalSalaries = data.Select(x=> x.Salary).Aggregate((a, b) => a + b);
            int result = totalSalaries / count;
            Console.WriteLine($"Average salary is: \t {result.ToString("C0", CultureInfo.CurrentCulture)}");
        }
    }
}