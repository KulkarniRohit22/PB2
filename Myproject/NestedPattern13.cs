using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedPattern13
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    if(i==3 || j==3)
                    {
                        Console.Write("  *");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    

                }
                Console.WriteLine();
            }
        }
    }
}
