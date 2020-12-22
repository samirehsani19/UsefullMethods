using System;
using System.Linq;

namespace UsefulMethods
{
    class RefAndOut
    {
        public void RefExample() //used to pass parameter with reference
        {
            //example 1
            //add 10 to num and print 20
            int num = 10;
            GetResut(ref num);
            Console.WriteLine(num); //20: 

            //Example 2
            //inrease samir's salary by 5000 kr
            var d = new Data();
            var data = d.GetData();

            var salary = data.FirstOrDefault(x => x.Name == "Samir").Salary;
            IncreaseSalary(ref salary);
            Console.WriteLine($"samir's salary is: {salary}");
        }

        private void IncreaseSalary(ref int salary)
        {
            salary += 5000;
        }

        private void GetResut(ref int num)
        {
            num += 10; // we have num and it's reference so any changes to num will effect the variable. 
        }

        internal void OutExample()
        {
            //Example 1
            int x = 5; // this value will be discarded bcz when you use out the method must assign it 
            DoMultiply(out x);
            Console.WriteLine(x); //10:

            //Example 2
            int y;
            DoDevide(out y);
            Console.WriteLine(y); //5:
        }

        private void DoDevide(out int x)
        {
            x = 10;
            x = x / 2; // 5 will be return to y variable
        }

        private void DoMultiply(out int x)
        {
            x = 2; // you are forced to give a value to x , the old value will be overriten.
            x *= 5;
        }

        internal void ParamsExample() //useful when you have multiple parameters
        {
            int x = 10;
            int y = 20;
            Add(y, x); // you are free to send more values as parameters
        }

        private void Add(params int[] values)
        {
            int result = 0;
            foreach (var item in values)
            {
                result = result + item;
            }
            Console.WriteLine(result);//30
        }
    }
}
