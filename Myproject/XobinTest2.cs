using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class XobinTest2
    {
        static void Main(string[] args)
        {
            //check whether a number is happyy number or not
            //i.e if every digit in a number is odd then that number is considered as a happy number.

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool IsHappy = true;

            for(; num>0; num = num / 10)
            {
                int r = num % 10;

               if(r % 2 == 0)
                {
                    IsHappy = false;
                    break;
                }
                
            }
            if(IsHappy)
            {
                Console.WriteLine("The number is happy number.");
            }
            else
            {
                Console.WriteLine("The number is not a happy number.");
            }
            
        }
    }
}
