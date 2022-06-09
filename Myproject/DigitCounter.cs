using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class DigitCounter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(;num>0;num=num/10)
            {
                int r = num % 10;
                count = count + 1;
            }
            Console.WriteLine(count);
        }
    }
}
