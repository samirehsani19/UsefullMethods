using System;
using System.Globalization;
using System.Linq;

namespace UsefulMethods
{
    internal class DelegateExamples
    {
        internal void FuncExample()  // func take an input type and and output type it can return any types
        {
            var d = new Data();
            var data = d.GetData();

            //Example 1
            //How much does Samir earn in one year?
            var samir = data.FirstOrDefault(x => x.Name == "Samir");

            Func<int, int> GetAnnualSalary = s => s * 12;
            var salary = GetAnnualSalary(samir.Salary);                 //C0: 420 000, 000. remove last 3 zeros
            Console.WriteLine($"Samir earn each year: \t {salary.ToString("C0", CultureInfo.CurrentCulture)}");

            //Example 2
            //Does Samir earn more than David?
            var david = data.FirstOrDefault(x => x.Name == "David");

            Func<Data, bool> WhoHasTheHighestSalary = s => s.Salary < samir.Salary;
            var result = WhoHasTheHighestSalary(david);
            Console.WriteLine(result); // true if Samid earn more than David
        }

        internal void ActionExample()  // action is like void method, it is good to display data 
        {
            var d = new Data();
            var data = d.GetData();

            //Example 1
            // display employee name
            Action<string> ShowAllEmployeeName = name => Console.WriteLine(name);
            data.ForEach(i => ShowAllEmployeeName(i.Name));


            //Example 2
            //show salary greater than 30000
            Action<Data> DisplaySalary = GetSalary;
            data.ForEach(i => DisplaySalary(i));
        }

        private void GetSalary(Data obj)
        {
            Console.WriteLine("\n List of salaries greater than 30000");
            if (obj.Salary > 30000) Console.WriteLine(obj.Salary);
        }

        internal void PredicateExample()  // predicate allways return true or false
        {
            var d = new Data();
            var data = d.GetData();

            //check empoyee with experience more than 5 years
            Predicate<double> CheckGreaterThan5 = e => e > 5;
            data.ForEach(i => Console.WriteLine("Is " + i.Name + "'s Experience greater than 5 years? \t\n" + CheckGreaterThan5(i.Experience)));
        }
    }

}