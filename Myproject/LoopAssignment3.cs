using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class LoopAssignment3
    {
        static void Main(string[] args)
        {
            //WAP to show the use of break statement.

            for(int i=1;i<=10;i++)
            {
                if(i == 5)
                {
                    break;
                    
                }
                Console.WriteLine(i);
            }
        }
    }
}
