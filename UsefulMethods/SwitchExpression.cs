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

        internal double SwitchMultipleCases => (1, 0) switch
        {
            (1, 0) => 1,  // Return 1 
            (1, 5) => 1.5,
            (2, 0) => 2,
            (2, 5)  => 2.5,
            _=> 0  //Else return this
        };
    }
}
