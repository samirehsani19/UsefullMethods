using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsefulMethods
{
    class LinqExamples
    {
        internal void GoupByEmployeesByGender()
        {
            var d = new Data();
            var data = d.GetData();

            var query = data.GroupBy(x => x.Gender).ToArray();
            foreach (var item in query)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Count()); //male - 6     female - 3
                //Console.WriteLine("{0} - {1}", item.Key, item.Count(x => x.Gender.ToString()=="Male")); //show only male employees. ouput: male - 6,    female - 0
            }
        }

        internal void GetMaximumSalay()
        {
            var d = new Data();
            var data = d.GetData();

            var query = from em in data
                       group em by em.Gender;

            foreach (var item in query)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Max(x => x.Salary)); //male 45000, female 48000
            }
        }

        internal void GoupEmployeeByProfessionAndDisplayName()
        {
            var d = new Data();
            var data = d.GetData();

            var query = from em in data
                        group em by em.Profession;

            foreach (var item in query)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Count()); 
                Console.WriteLine("--------------------");
                foreach (var i in item)
                {
                    Console.WriteLine(i.Name + "\t" + i.Profession);
                }
                Console.WriteLine();
            }

                /*output:
                 
                developer: 2
                --------------------
                Samir   developer
                David   developer

                Designer: 3
                --------------------
                Jan     Designer
                Mike    Designer
                Emma    Designer

                Tester: 2
                --------------------
                Hanna   Tester
                Ali     Tester

                Manager: 1
                --------------------
                Musse   Manager

                Scrum master: 1
                --------------------
                Angela  Scrum master
                    
                                       */
        }

        internal void GoupByMultiple()
        {
            var d = new Data();
            var data = d.GetData();

            //Same query
            //var query = from em in data
            //            group em by new { em.Gender, em.Profession, em.Name } into g
            //            orderby g.Key.Profession, g.Key.Gender 
            //            select new 
            //            {
            //                professtion = g.Key.Profession,
            //                gender= g.Key.Gender,
            //                emplyees = g.OrderBy(x=>x.Name)
            //            };

            var query = data.GroupBy(x => new { x.Profession, x.Gender })
                .OrderBy(p => p.Key.Profession).ThenBy(g => g.Key.Gender)
                .Select(e => new
                {
                    Profession = e.Key.Profession,
                    Gender = e.Key.Gender,
                    Employees = e.OrderBy(x=>x.Name)
                });


            foreach (var item in query)
            {
                Console.WriteLine($"Name \t Gender \t Profession \t Employee count = {item.Employees.Count()}");
                Console.WriteLine("---------------------------------------------------------------");

                foreach (var i in item.Employees)
                {
                    Console.WriteLine($"{i.Name} \t {i.Gender}\t\t {i.Profession}");
                }
                Console.WriteLine();
            }

            /*output:
            Name     Gender          Profession      Employee count = 2
            ---------------------------------------------------------------
            Jan      Male            Designer
            Mike     Male            Designer

            Name     Gender          Profession      Employee count = 1
            ---------------------------------------------------------------
            Emma     Female          Designer

            Name     Gender          Profession      Employee count = 2
            ---------------------------------------------------------------
            David    Male            developer
            Samir    Male            developer

            Name     Gender          Profession      Employee count = 1
            ---------------------------------------------------------------
            Musse    Male            Manager

            Name     Gender          Profession      Employee count = 1
            ---------------------------------------------------------------
            Angela   Female          Scrum master

            Name     Gender          Profession      Employee count = 1
            ---------------------------------------------------------------
            Ali      Male            Tester

            Name     Gender          Profession      Employee count = 1
            ---------------------------------------------------------------
            Hanna    Female          Tester

             * */

        }


    }
}
