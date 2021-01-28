using System;
using System.Threading;
using System.Timers;

namespace AutoResetEventApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1.DoWork();  // Keep waiting until manually released or timeout is out
            Class2.Release();  // Releasing thread
        }
    }
}
