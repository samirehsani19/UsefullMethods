using System;
using System.Collections.Generic;
using System.Text;

namespace AutoResetEventApp
{
    class Class2
    {
        public static void Release()
        {
            Class1.Start();  // Start Releasing thread
        }
    }
}
