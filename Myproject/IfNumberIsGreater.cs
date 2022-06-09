using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class IfNumberIsGreater
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 5)
            {
                Console.WriteLine("The number is greater than 5: ");
            }
            else
            {
                Console.WriteLine("The number is less than 5: ");
            }
        }
    }
}
