using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment14
    {
        // write a programme to check whether the given no is krishnamurthy no or not.
        //ex. 153 = 1! + 5! + 3! = 153

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            int temp = num;

            while(num > 0)
            {
                int n = num % 10;
                int fact = 1;
                for(int i=1; i<=n; i++)
                {
                    fact = fact * i;
                    sum = sum * fact;
                }

                
                num = num / 10;
            }
            num = temp;


            Console.WriteLine(num);
            Console.WriteLine("The sum is :" + sum);
            
            if (num == sum)
            {
                Console.WriteLine("The number is krishnamurthy number.");
            }
            else {
                Console.WriteLine("The number is not krishnamurthy number.");
            }
        }
    }
}
