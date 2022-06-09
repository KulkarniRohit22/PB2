using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedDemo
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            { 
                for(int j=1; j<=3; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
