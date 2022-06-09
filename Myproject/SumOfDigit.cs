using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SumOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (; num > 0; num = num / 10)
            {
                int r = num % 10;
                sum = sum + r;
            }
            Console.WriteLine(sum);
        }
    }
}
