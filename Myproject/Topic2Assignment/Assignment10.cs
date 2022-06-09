using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment10
    {
        //WAP a program to check whether entered number is 3 digit or not .If it is a 3 digit no. then do sum of 1st and 3rd digit and print sum.
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int firstdigit = 0;
            int lastdigit = num % 10;
            int sum = 0;
            int reverse = 0;

            for(; num>0; num = num / 10)
            {
                int r = num % 10;
                count++;
            }
            Console.WriteLine(count);
            if(count == 3)
            {
                //firstdigit = num;
                while (num >0)
                {
                    int r = num % 10;
                    reverse = reverse * 10 + r;
                    num = num / 10; 
                }
                firstdigit = reverse % 10;
                sum = firstdigit + lastdigit;
                Console.WriteLine("The sum of first and last digit is: " +sum);
            }
            else
            {
                Console.WriteLine("done");
            }
        }
    }
}
