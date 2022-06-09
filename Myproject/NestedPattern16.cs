using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedPattern16
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for (int k = 5; k > i; k--)
                {
                    Console.Write("  ");
                }
                for (int j=1; j<=i;j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
