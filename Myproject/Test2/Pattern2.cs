using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Test2
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=1; i<=n; i++)
            {
                for(int j=i ; j>=1; j--)
                {
                    for (int k = i; k <= n; k++)
                    {
                        Console.Write("");
                    }
                    if (j % 2 == 1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
