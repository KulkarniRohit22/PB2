using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment2
    {
        //Write a programee to check whether a number is divisible by 5 and 11 or not

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("The number is divisible by 5 and 11.");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 5 and 11.");
            }
        }
    }
}
