using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace UsefulMethods
{
    public static class YieldAndAggregate
    {
        internal static void YieldExample() // custome iteration of yield
        {
            //Example 1
            foreach (var item in GetEmployeeOlderThan30())
            {
                Console.WriteLine($"{item.Name} \t {item.Age}");
            }

        }

        internal static IEnumerable<Data> GetEmployeeOlderThan30() 
        {
            var d = new Data();
            var data = d.GetData();

            foreach (var item in data)
            {
                if(item.Age > 30)  
                {
                    yield return item;  // each time the condition is filled it return data to method caller and come back to check next one
                                        //and it remember it's current index, next time it comes back it will check after the index that it previosly checked
                }
            }

        }


        internal static void AggregateExample() // use over a collection to to math, no need for loop
        {
            //Example 1
            int[] numbers = {2, 3, 4, 5 };

            //first a get 2 and b get 3 then do multiple, then store result in a and b get new value which is 4 and multiple and so on ... 
            var product = numbers.Aggregate((a, b) => a * b); 
            Console.WriteLine(product); //120


            //Example 2
            //what is the sum of numbers if you plus it with 6?
            var sum = numbers.Aggregate(6,(a, b) => a + b); //seed 6 
            Console.WriteLine(sum); //20


            //Example 3
            var d = new Data();
            var data = d.GetData();

            //how much money do company pays to employee in one month?
            var totalSalaries = data.Select(x => x.Salary).Aggregate((a, b) => a + b);
            Console.WriteLine(totalSalaries.ToString("C0", CultureInfo.CurrentCulture)); // 347 000 kr

        }


    }
}
