using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class LoopAssignment2
    {
        static void Main(string[] args)
        {
            //WAP to print odd numbers from 521 to 229 using while loop.

            int i = 521;
            while(i>=229)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
        }
    }
}
