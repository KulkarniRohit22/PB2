using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment9
    {
        static void Main(string[] args)
        {
              //Write a program to find the frequency of each digit in a given integer.

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(; num>0; num = num / 10)
            {
                int r = num % 10;
                if(r >= 0 && r <= 9)
                {
                    count++;
                }
                Console.WriteLine(r);
                Console.WriteLine(count);
            }
        }
    }
}
