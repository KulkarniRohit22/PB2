using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Test2
{
    class NumberPower
    {

        static void Main(string[] args)
        {
            Console.WriteLine("ENter a base number");
            int base1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of exponent");
            int exponent = Convert.ToInt32(Console.ReadLine());
         

            long result = 1;

            for (; exponent != 0; --exponent)
            {
                result *= base1;
            }

            Console.WriteLine("Answer = " + result);
        }
    }
}
