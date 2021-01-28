using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoResetEventApp
{
    class Class1
    {
        static AutoResetEvent auto = new AutoResetEvent(false);

        public static void Start()
        {
            Console.WriteLine("\n released \n");
            auto.Set();
        }

        public static void DoWork()
        {
            new Thread(First).Start();
        }
        private static void First()
        {
            Console.WriteLine("\n First");
            auto.WaitOne(5000);
            Second();
        }

        private static void Second()
        {
            Console.WriteLine("\n Second");
        }
    }
}
