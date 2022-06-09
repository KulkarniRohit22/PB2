using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int temp = num;
           

            for(; num>0; num = num / 10 )
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
               
            }
            num = temp;
            Console.WriteLine(num);
            Console.WriteLine(reverse);

            if (num != reverse)
            {
                Console.WriteLine("The number is not palindrome");
            }
            else
            {
                Console.WriteLine("The number is palindrome");
            }
        }
    }
}
