using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment8
    {
        static void Main(string[] args)
        {
            //WAP to calculate the product of digits in any number.

            Console.WriteLine("ENter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int product = 1;

            for(; num>0; num = num / 10)
            {
                int r = num % 10;
                product = product * r;
                
            }
            Console.WriteLine(product);
        }
    }
}
