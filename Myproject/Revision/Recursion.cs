using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class Recursion
    { 
        static int factorial(int n )
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }

        }
        static void Main(string[] args)
        {
            int ans = factorial(4);
            Console.WriteLine(ans);
        }
    }
}
