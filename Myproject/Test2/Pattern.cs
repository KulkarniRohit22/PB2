using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Test2
{
    class Pattern
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=1; i<=n; i++)
            {
                for (int j = i; j >=1 ; j--)
                {
                    Console.Write("");
                }   
                for(int k=i; k>=1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
}
