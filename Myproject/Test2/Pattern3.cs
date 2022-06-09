using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Test2
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();


            }
        }
    }
}
