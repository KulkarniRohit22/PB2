using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
           

            for( ; num > 0; num = num / 10)
            {
                int r = num % 10;
                sum =  (r * r * r) + sum;
            }
            if(sum == num)
            {
                Console.WriteLine("It is an not armstrong number");
            }
            else
            {
                Console.WriteLine("It is  an armsgtrong number");
            }
            Console.Write(sum);
            
        }
    }
}
