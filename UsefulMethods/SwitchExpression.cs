using System;

namespace UsefulMethods
{
    class SwitchExpression
    {
        public void DoSwitch()
        {
            int number = 4;
            var result = number switch
            {
                1 => "Number is 1",
                2 => "Number is 2",
                3 => "Number is 3",
                4 => "Number is 4",
                _ => "Number not found"
            };
            Console.WriteLine(result);
        }
    }
}
