﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedPattern1
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                        Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
}
