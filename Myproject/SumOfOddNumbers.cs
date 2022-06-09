using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for (i = 25; i <= 75; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
               

            }
            Console.WriteLine(sum);
        }
    }
}
