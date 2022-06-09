using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ThreeNumberComparison
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 )
            {
                if(num1 > num3)
                {
                    Console.WriteLine("num1 is greater number.");
                
                }
                else
                {
                    Console.WriteLine("num3 is greater number.");
                }
                
            }

            else if(num2 > num3)
            {
                Console.WriteLine("num2 is greater number.");
            }
            else
            {
                Console.WriteLine("num3 is greatest number.");
            }
        }
    }
}
