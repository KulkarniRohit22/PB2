using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class DisariumNumberUsingPowerMethod
    {
        static void Main(string[] args)
        {
            int num = 135, sum =0, r, temp, count =0;

            temp = num;

            while(num > 0)
            {
                count++;
                num = num / 10;
            }

            Console.WriteLine(count);

            while(num > 0)
            {
                r = num % 10;
                sum = sum + (int) Math.Pow(r,count);
                count--;
                num = num / 10;
            }

            num = temp;
            Console.WriteLine(num);
            if(num == sum)
            {
                Console.WriteLine("The number is not disarium number." +num );
            }
            else
            {
                Console.WriteLine("The number is disarium number." + count);
            }
        }
    }
}
