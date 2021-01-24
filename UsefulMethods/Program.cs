using System;
using static UsefulMethods.GenericType;

namespace UsefulMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //*************delegate**********************
            //DelegateExamples e = new DelegateExamples();
            //e.FuncExample();
            //e.ActionExample();
            //e.PredicateExample();


            //*************Useful Examples**********************
            //YieldAndAggregate.YieldExample();
            //YieldAndAggregate.AggregateExample();

            //*************Ref And Out**********************
            //RefAndOut r = new RefAndOut();
            //r.RefExample();
            //r.OutExample();
            //r.ParamsExample();


            //*************Linq Examples**********************
            //LinqExamples l = new LinqExamples();
            //l.GoupByEmployeesByGender();
            //l.GetMaximumSalay();
            //l.GoupEmployeeByProfessionAndDisplayName();
            //l.GoupByMultiple();


            //*************Extention method**********************
            //ExtentionMethodExample e = new ExtentionMethodExample();
            //e.SayWelcome();


            //*************Regular expression **********************
            //RegularExpressionExample r = new RegularExpressionExample();
            //r.CheckForValidation();


            //*************Switch expression**********************
            //SwitchExpression s = new SwitchExpression();
            //Console.WriteLine(s.SwitchMultipleCases);
            //s.DoSwitch();

            Person p = new Person {Name="Hanna", Age=20 };
           
            GenericType g = new GenericType();
            g.GetType(p);   // Display Person

            g.DisplayName(p); // display Hanna

            g.AddToList(p);// Display 1


            Console.ReadKey();
        }
    }
}
