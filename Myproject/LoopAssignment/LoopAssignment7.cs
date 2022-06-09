using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment7
    {
        static void Main(string[] args)
        {
            //WAP to count number of digits in any number.

            Console.WriteLine("Enter the number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (; num > 0; num = num / 10)
            {
                int r = num % 10;
                count++;
                
            }
            
            Console.WriteLine(count);
        }   
    }
}
