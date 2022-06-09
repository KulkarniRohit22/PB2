using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedPattern10
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=n; j++)
                {


                    if (i == n ||  j == 1 || i == j)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                    
                }
                
                Console.WriteLine();
            }
        }
    }
}
