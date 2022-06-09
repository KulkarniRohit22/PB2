using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment5
    {
        static void Main(string[] args)
        {
            //WAP to find the sum of all the even numbers between 1 to n.

            int i, n=50, sum = 0;
            for(i=1; i<=n; i++)
            {
                if(i % 2 == 0)
                {
                    sum = sum + i;
                  
                    Console.WriteLine(sum);
                }
                
            }
        }
    }
}
