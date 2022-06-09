using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class LoopAssignment1
    {
        static void Main(string[] args)
        {
            //WAP to print all the even numbers fro 121 to 229 using for loop.

            for(int i =121;i<=229;i++)
            {
                if(i %2 ==0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
