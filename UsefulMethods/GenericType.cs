using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UsefulMethods
{
    public class GenericType
    {
        public void GetType<T>(T entity) where T : class
        {
            Console.WriteLine("the type is " + entity.GetType());
        }

        public void DisplayName<T>(T entity) where T : Person
        {
            Console.WriteLine(entity.Name);
        }

        public void AddToList<T>(T entity) where T : class
        {
            var list = new List<T>();
            list.Add(entity);

            Console.WriteLine(list.Count);
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
