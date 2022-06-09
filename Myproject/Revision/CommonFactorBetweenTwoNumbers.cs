using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class CommonFactorBetweenTwoNumbers
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 4; // 1,2,4

            for(int i=1; i<=a &&  i<=b; i++)
            {
                if(a % i == 0 && b % i == 0  )
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
