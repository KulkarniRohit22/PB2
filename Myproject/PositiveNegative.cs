using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if(num1 > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }
        }
    }
}
